using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpChess.Forms
{
    #region Using
    using SharpChess.Model;
    #endregion

    public partial class frmPieceOrder : Form
    {
        private int[] order;
        public static int WHITE = 0;
        public static int BLACK = 1;

        public frmPieceOrder(int color)
        {
            InitializeComponent();
            if (color == WHITE)
            {
                WhiteBishop1.Visible = true;
                WhiteBishop2.Visible = true;
                WhiteKnight1.Visible = true;
                WhiteKnight2.Visible = true;
                WhiteRook1.Visible = true;
                WhiteRook2.Visible = true;
                WhiteQueen.Visible = true;
            }
            else if (color == BLACK)
            {
                BlackBishop1.Visible = true;
                BlackBishop2.Visible = true;
                BlackKnight1.Visible = true;
                BlackKnight2.Visible = true;
                BlackRook1.Visible = true;
                BlackRook2.Visible = true;
                BlackQueen.Visible = true;
            }
        }

        private void SelectOrder_Click(object sender, EventArgs e)
        {
            order = new int[7];
            //Set order for each piece.
            order[0] = (int)numericUpDownRook1.Value;
            order[1] = (int)numericUpDownKnight1.Value;
            order[2] = (int)numericUpDownBishop1.Value;
            order[3] = (int)numericUpDownQueen.Value;
            order[4] = (int)numericUpDownBishop2.Value;
            order[5] = (int)numericUpDownKnight2.Value;
            order[6] = (int)numericUpDownRook2.Value;

            bool valid_order = true;

            for (int i = 0; i < order.Length - 1; i++)
            {
                for (int j = i + 1; j < order.Length; j++)
                {
                    /* If all elements of order are not unique, then the
                     * piece order is not valid.
                     */
                    if (order[i] == order[j])
                    {
                        valid_order = false;
                        break;
                    }
                }
                //No use continuing since we know the order is not valid.
                if (!valid_order)
                {
                    break;
                }
            }

            if (valid_order)
            {
                //We're done.
                parseOrder();
                this.Close();
            }
            else
            {
                //stay on form and display error message
                errorMessage.Visible = true;
            }
        }

        private void randomOrder_Click(object sender, EventArgs e)
        {
            order = null;
            this.Close();
        }

        /// <summary>
        ///     Parse the order from piece ranking to actual positions
        ///     on the chess board.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        private void parseOrder()
        {
            //Set Game's white_order variable to record the selected order.
            for (int i = 0; i < order.Length; i++)
            {
                /* Turn arrangement numbers in to valid row indices.
                 * The King is always in slot 4 counting from 0.
                 */
                switch (order[i])
                {
                    //These pieces come before the King
                    case 1:     //slot 0
                    case 2:     //slot 1
                    case 3:     //slot 2
                    case 4:     //slot 3
                        order[i] -= 1;
                        break;
                    //These pieces come after the King
                    case 5:     //slot 5
                    case 6:     //slot 6
                    case 7:     //slot 7
                        //do nothing to ranks of these pieces
                        break;
                    default:
                        //Error:  order is null
                        order = null;
                        break;
                }
            }
        }
        public int[] getOrder()
        {
            return order;
        }
    }
}
