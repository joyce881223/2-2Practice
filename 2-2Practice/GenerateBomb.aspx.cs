using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class GenerateBomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_Bomb = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            int i_Row = 0, i_Col = 0;
            int[,] ia_2DMap = new int[10, 10];

            for(int i_Ct = 0; i_Ct < ia_Bomb.Length; i_Ct++)
            {
                mt_GetRowCol(ref i_Row, ref i_Col, ia_Bomb[i_Ct]);
                ia_2DMap[i_Row, i_Col] = -1;
            }
            for(int i_Ct = 0; i_Ct < 10; i_Ct++)
            {
                for(int i_Ct2 = 0; i_Ct2 < 10; i_Ct2++)
                {
                    Response.Write(ia_2DMap[i_Ct, i_Ct2]);
                }
                Response.Write("<br />");
            }
        }

        private void mt_GetRowCol(ref int i_Row, ref int i_Col, int v)
        {
            throw new NotImplementedException();
        }
    }
}