using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
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
            tooltip.SetToolTip(control, description); //tu sam dobila nuulpointException
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
    }
    
}
