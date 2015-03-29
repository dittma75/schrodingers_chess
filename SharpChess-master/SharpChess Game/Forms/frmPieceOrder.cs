﻿using System;
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
        public frmPieceOrder()
        {
            InitializeComponent();
        }

        private void SelectOrder_Click(object sender, EventArgs e)
        {
            int[] order = new int[7];
            //Set order for each piece.
            order[0] = (int)numericUpDownRook1.Value;
            order[1] = (int)numericUpDownKnight1.Value;
            order[2] = (int)numericUpDownBishop1.Value;
            order[3] = (int)numericUpDownQueen.Value;
            order[4] = (int)numericUpDownRook2.Value;
            order[5] = (int)numericUpDownKnight2.Value;
            order[6] = (int)numericUpDownBishop2.Value;

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
                //Set Game's WhiteOrder variable to record the selected order.
                for (int i = 0; i < order.Length; i++)
                {
                    Game.WhiteOrder[i] = order[i];
                }
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
            Game.WhiteOrder = null;
            this.Close();
        }
    }
}
