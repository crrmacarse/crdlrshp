using cardealership.Common.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace cardealership.Class
{

    public class MsgTypes
    {
        public const string info = "info";
        public const string danger = "danger";
        public const string warning = "warning";
        public const string question = "question";
        public const string success = "success";
    }

    public static class General
    {
        public static clsAccountUser currentUser = null;
        
        public enum ApplicationState
        {
            Busy,
            Ready,
            Processing,
            SigningIn
        }

        /// <summary>
        ///  System Messagebox
        /// </summary>
        /// <param name="title">Main title</param>
        /// <param name="description">Messge Description</param>
        /// <param name="types">Message Types</param>
        /// <param name="subtitle">Optional Subtitle. Useful for additional details</param>
        /// <returns></returns>
        public static void showMessageBox(string title, string description, string types = MsgTypes.info, string subtitle = "")
        {
            frmMessageBox frm = new frmMessageBox();

            frm.Title = title;
            frm.SubTitle = subtitle;
            frm.MsgType = types;
            frm.Description = description;

            // could add a dialog result here that handles questions
            frm.ShowDialog();
        }

        public static DialogResult askQuestion(string title, string description, string subtitle = "")
        {
            frmMessageBox frm = new frmMessageBox();

            frm.Title = title;
            frm.SubTitle = subtitle;
            frm.MsgType = MsgTypes.question;
            frm.Description = description;

            // could add a dialog result here that handles questions
            DialogResult result = frm.ShowDialog();

            return result;
        }

        public static string connectionString(string database = null)
        {
            if (database == null) { database = "CarDealership"; }

            clsConnection conn = new clsConnection("localhost", "sa", "garudatiger", database);

            return conn.createConnectionString();
        }

        /// <summary>
        /// Settings Application State in Main
        /// </summary>
        /// <param name="appstate"></param>
        public static void setApplicationState(ApplicationState appstate)
        {
            Color backColor;
            string stateText;

            switch (appstate)
            {
                case ApplicationState.Busy:
                    backColor = Color.FromArgb(242, 155, 26);
                    stateText = "Busy...";
                    break;
                case ApplicationState.Ready:
                    backColor = Color.FromArgb(233, 84, 32);
                    stateText = "Ready.";
                    break;
                case ApplicationState.Processing:
                    backColor = Color.FromArgb(242, 155, 26);
                    stateText = "Processing...";
                    break;
                case ApplicationState.SigningIn:
                    backColor = Color.FromArgb(242, 155, 26);
                    stateText = "Sign-in first..";
                    break;
                default:
                    backColor = Color.FromArgb(233, 84, 32);
                    break;

            }

            // idk how to access the form still and change the values in there or something 
            // about accesing a function in main and pass this variable to control

        }

        public static bool VerifyAccount(string username, string password)
        {
            clsAccountUser auth = new clsAccountUser();
            currentUser = auth.authenticate(username, password);

            if(currentUser != null)
            {
                return true;
            }

            return false;
        }

    }

    

    

}
