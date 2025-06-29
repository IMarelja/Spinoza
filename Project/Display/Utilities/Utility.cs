using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Display.Utilities
{
    public class Utility
    {
        public Utility() { }

        /*
         * =====================================================
         * 👍 Simulations that will be used in Applications 👍
         * =====================================================
         * 
         * ⚠️ Constructers places inside must accept nothing and return nothing by themselves
         * They are used for mostly returning the Description and Name ⚠️
         */
        public static List<Grid> approvedSimulationsGrids = new List<Grid>
        {
            new Brain(),
            new LangtonsGrid(),
            new Forest()
        };


        /*
         * ================================================
         * 🏠 Home path where the simulation is running 🏠
         * ================================================
         */

        public static string HomePath()
        {
            if (!DebugDirectoryChecker())
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
            return Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        }

        private static bool DebugDirectoryChecker()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;

            var normalizedPath = Path.GetFullPath(baseDir)
                                     .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                                     .ToLowerInvariant();

            return normalizedPath.Contains(Path.Combine("bin", "debug").ToLowerInvariant()) ||
                   normalizedPath.Contains(Path.Combine("bin", "release").ToLowerInvariant());
        }


        /*
         * ================================================================
         * 🎛️ℹ️ Creates Informational Tooltips balloon for a Control ℹ️🎛️
         * ================================================================
         * Always happens:
         * - Uses the Windows default Info icon
         * - Is a Window'es standard Balloon
         * - Will place info inside a called Control
         */
        public static void SetInfoBalloonTooltipForControl(System.Windows.Forms.ToolTip tooltip, Control control, string title, string description)
        {
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.ToolTipTitle = title;
            tooltip.SetToolTip(control, description);
        }


        /*
         * ===============================================================================
         * 🦠ℹ️ Creates Informational Tool tips balloon only for CELL state Controls 🦠ℹ️
         * ===============================================================================
         * Always happens:
         * - Icon is not functional (it is drawing it but it isnt visible)
         * - Is a Window'es standard Balloon
         * - Will place info inside a called Control
         */
        public static void CreateCellStateTooltip(System.Windows.Forms.ToolTip tt, Control target, Panel panelColor, string message)
        {
            tt.IsBalloon = true;
            tt.ToolTipIcon = ToolTipIcon.None; // No default icon
            tt.ToolTipTitle = target.Text; // Optional, leave empty or add something like "Status: Alive"

            // Use owner draw for custom image/icon
            tt.OwnerDraw = true;
            tt.Popup += (s, e) => { e.ToolTipSize = new Size(200, 80); };

            tt.Draw += (s, e) =>
            {
                // Draw background
                e.DrawBackground();
                // Draw color icon
                using (SolidBrush brush = new SolidBrush(panelColor.BackColor))
                {
                    e.Graphics.FillRectangle(brush, new Rectangle(10, 10, 20, 20));
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(10, 10, 20, 20));
                }

                // Draw message
                using (Font font = new Font("Segoe UI", 9))
                {
                    e.Graphics.DrawString(message, font, Brushes.Black, new RectangleF(40, 10, 150, 60));
                }
            };

            tt.SetToolTip(target, message); // Needed to trigger the draw event
            tt.SetToolTip(panelColor, message);
        }

        //
        // Saving logged in user on a file and he will automatically log in after starting up the app
        //
        public static void SaveLoginToFile(AuthLogin loginData)
        {
            string filePath = "login.txt";

            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, loginData.Formate());
            }
            else
            {
                File.WriteAllText(filePath, loginData.Formate());
            }
        }

        //
        // Deleting user on a file
        //
        public static void DelteLoginOfFile()
        {
            string filePath = "login.txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath); //delete file
                //File.WriteAllText(filePath, string.Empty); //delete content
            }
        }

        public static void SaveGridToFile(Grid gridLoaded)
        {
            if (gridLoaded == null)
                throw new ArgumentNullException(nameof(gridLoaded), "Grid can not be empty.");

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save the grid state";
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = $"{gridLoaded.Name}_{DateTime.Now:yyyyMMdd_HHmmss}.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string JSON = gridLoaded.SaveGridToJsonFile();

                    try
                    {
                        File.WriteAllText(filePath, JSON);
                    }
                    catch (IOException ex)
                    {
                        throw new InvalidOperationException($"Failed to save the file: {ex.Message}", ex);
                    }

                }
                else
                {
                    throw new OperationCanceledException("Import operation was cancelled.");
                }
            }
        }


        public static T ImportGridFromAFile<T>() where T : Grid, new()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configure the dialog
                openFileDialog.Title = "Import Grid State";
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.DefaultExt = "json";

                // Show the dialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        T instance = new T();
                        instance.ImportGridFromJsonFile(filePath);
                        return instance;
                    }
                    catch (JsonException ex)
                    {
                        throw new InvalidOperationException($"Invalid JSON format: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        throw new InvalidOperationException($"Error reading file: {ex.Message}");
                    }
                }
                else
                {
                    throw new OperationCanceledException("Import operation was cancelled.");
                }
            }
        }

        private static int[,] ConvertToMultiDimensionalArray(int[][] jaggedArray)
        {
            if (jaggedArray == null || jaggedArray.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");

            int rows = jaggedArray.Length;
            int cols = jaggedArray[0].Length;

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = jaggedArray[i][j];
                }
            }

            return result;
        }

    }
}
