using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWMM.Components
{
    public enum TEditStyle
    {
        esNone = 0,
        esNumber = 1,
        esPosNumber = 2,
        esNoSpace = 3
    }
    public class TNumEdit : System.Windows.Forms.TextBox
    {
        public TEditStyle Style { get; set; }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            // Allow backspace key press
            if (e.KeyCode == Keys.Back) return;

            // For numeric entries
            if (this.Style == TEditStyle.esNumber || this.Style == TEditStyle.esPosNumber)
            {
                string S = this.Text;
                //        // Insert the key character into the current text
                //        S:= Text;
                //            Delete(S, SelStart + 1, SelLength);
                //            Insert(Key, S, SelStart + 1);

                //        // Add a 1 to complete a partial numeric entry
                //        S:= S + '1';

                //            // Check that this creates a valid number
                //            try
                //  X:= StrToFloat(S);

                //            // Check if a positive number is required
                //            if (FStyle = esPosNumber) and(X < 0.0) then Key := #0;

                //// Ignore the key if we don't have a valid number
                //except
                //              on EConvertError do Key:= #0;
                //end;
            }
            else if (this.Style == TEditStyle.esNoSpace)
            {
                // if CharInSet(Key,[' ', '"', ';']) then Key := #0;
            }
        }
    }
}
