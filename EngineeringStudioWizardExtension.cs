using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.Variable;
using System;

namespace EnkelExempelWizard
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("ExempelWizard", "Ett enkelt exempel på en Wizard för zenon Editor.", "Exempel på svenska")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation

        public void Run(IEditorApplication context, IBehavior behavior)
        {
            try
            {
                Form1 frm = new Form1(context.Workspace.ActiveProject.DriverCollection, context.Name);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }

}