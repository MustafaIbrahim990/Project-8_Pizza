namespace Pizza_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labTitleName = new System.Windows.Forms.Label();
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chbExtraChees = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.labOrderSummary = new System.Windows.Forms.Label();
            this.labPizzaSize = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.labPS = new System.Windows.Forms.Label();
            this.labT = new System.Windows.Forms.Label();
            this.labTP = new System.Windows.Forms.Label();
            this.labCT = new System.Windows.Forms.Label();
            this.labWTE = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.gbPizzaSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitleName
            // 
            this.labTitleName.AutoSize = true;
            this.labTitleName.Font = new System.Drawing.Font("Goudy Stout", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleName.ForeColor = System.Drawing.Color.Red;
            this.labTitleName.Location = new System.Drawing.Point(248, 31);
            this.labTitleName.Name = "labTitleName";
            this.labTitleName.Size = new System.Drawing.Size(918, 68);
            this.labTitleName.TabIndex = 0;
            this.labTitleName.Text = "MAKE YOUR PIZZA";
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.Controls.Add(this.rbLarge);
            this.gbPizzaSize.Controls.Add(this.rbMedium);
            this.gbPizzaSize.Controls.Add(this.rbSmall);
            this.gbPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaSize.Location = new System.Drawing.Point(78, 140);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Size = new System.Drawing.Size(148, 161);
            this.gbPizzaSize.TabIndex = 1;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Pizza Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(43, 120);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(73, 24);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(43, 78);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(89, 24);
            this.rbMedium.TabIndex = 6;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(43, 36);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(72, 24);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(78, 368);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(161, 132);
            this.gbCrustType.TabIndex = 2;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(32, 84);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(116, 24);
            this.rbThickCrust.TabIndex = 6;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(32, 47);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(108, 24);
            this.rbThinCrust.TabIndex = 5;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chbGreenPeppers);
            this.gbToppings.Controls.Add(this.chbExtraChees);
            this.gbToppings.Controls.Add(this.chbOlives);
            this.gbToppings.Controls.Add(this.chbTomatoes);
            this.gbToppings.Controls.Add(this.chbOnion);
            this.gbToppings.Controls.Add(this.chbMushrooms);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(482, 145);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(390, 171);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chbGreenPeppers
            // 
            this.chbGreenPeppers.AutoSize = true;
            this.chbGreenPeppers.Location = new System.Drawing.Point(176, 129);
            this.chbGreenPeppers.Name = "chbGreenPeppers";
            this.chbGreenPeppers.Size = new System.Drawing.Size(144, 24);
            this.chbGreenPeppers.TabIndex = 9;
            this.chbGreenPeppers.Text = "Green Peppers";
            this.chbGreenPeppers.UseVisualStyleBackColor = true;
            this.chbGreenPeppers.CheckedChanged += new System.EventHandler(this.chbGreenPeppers_CheckedChanged);
            // 
            // chbExtraChees
            // 
            this.chbExtraChees.AutoSize = true;
            this.chbExtraChees.Location = new System.Drawing.Point(6, 45);
            this.chbExtraChees.Name = "chbExtraChees";
            this.chbExtraChees.Size = new System.Drawing.Size(123, 24);
            this.chbExtraChees.TabIndex = 4;
            this.chbExtraChees.Text = "Extra Chees";
            this.chbExtraChees.UseVisualStyleBackColor = true;
            this.chbExtraChees.CheckedChanged += new System.EventHandler(this.chbExtraChees_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(176, 87);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(78, 24);
            this.chbOlives.TabIndex = 7;
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Location = new System.Drawing.Point(6, 129);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(105, 24);
            this.chbTomatoes.TabIndex = 8;
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.chbTomatoes_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(176, 45);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(75, 24);
            this.chbOnion.TabIndex = 5;
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.chbOnion_CheckedChanged);
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Location = new System.Drawing.Point(6, 87);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(119, 24);
            this.chbMushrooms.TabIndex = 6;
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            this.chbMushrooms.CheckedChanged += new System.EventHandler(this.chbMushrooms_CheckedChanged);
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.Location = new System.Drawing.Point(1037, 386);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(136, 20);
            this.labWhereToEat.TabIndex = 4;
            this.labWhereToEat.Text = "Where To Eat :";
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(482, 386);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(390, 64);
            this.gbWhereToEat.TabIndex = 5;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(176, 29);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(98, 24);
            this.rbTakeOut.TabIndex = 7;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(6, 29);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(73, 24);
            this.rbEatIn.TabIndex = 6;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // labOrderSummary
            // 
            this.labOrderSummary.AutoSize = true;
            this.labOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderSummary.Location = new System.Drawing.Point(1007, 145);
            this.labOrderSummary.Name = "labOrderSummary";
            this.labOrderSummary.Size = new System.Drawing.Size(141, 20);
            this.labOrderSummary.TabIndex = 6;
            this.labOrderSummary.Text = "Order Summary";
            // 
            // labPizzaSize
            // 
            this.labPizzaSize.AutoSize = true;
            this.labPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPizzaSize.Location = new System.Drawing.Point(1037, 194);
            this.labPizzaSize.Name = "labPizzaSize";
            this.labPizzaSize.Size = new System.Drawing.Size(111, 20);
            this.labPizzaSize.TabIndex = 7;
            this.labPizzaSize.Text = "Pizza Size :";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.Location = new System.Drawing.Point(1037, 236);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(97, 20);
            this.labToppings.TabIndex = 8;
            this.labToppings.Text = "Toppings :";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.Location = new System.Drawing.Point(1037, 430);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(113, 20);
            this.labTotalPrice.TabIndex = 10;
            this.labTotalPrice.Text = "Total Price :";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(482, 489);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(189, 53);
            this.btnOrderPizza.TabIndex = 11;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(683, 489);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(189, 53);
            this.btnResetForm.TabIndex = 12;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            // 
            // labPS
            // 
            this.labPS.AutoSize = true;
            this.labPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPS.Location = new System.Drawing.Point(1156, 194);
            this.labPS.Name = "labPS";
            this.labPS.Size = new System.Drawing.Size(53, 20);
            this.labPS.TabIndex = 13;
            this.labPS.Text = "label1";
            // 
            // labT
            // 
            this.labT.AutoSize = true;
            this.labT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labT.Location = new System.Drawing.Point(1156, 236);
            this.labT.Name = "labT";
            this.labT.Size = new System.Drawing.Size(18, 20);
            this.labT.TabIndex = 14;
            this.labT.Text = "1";
            // 
            // labTP
            // 
            this.labTP.AutoSize = true;
            this.labTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labTP.Location = new System.Drawing.Point(1171, 452);
            this.labTP.Name = "labTP";
            this.labTP.Size = new System.Drawing.Size(108, 76);
            this.labTP.TabIndex = 15;
            this.labTP.Text = "$0";
            // 
            // labCT
            // 
            this.labCT.AutoSize = true;
            this.labCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCT.Location = new System.Drawing.Point(1170, 339);
            this.labCT.Name = "labCT";
            this.labCT.Size = new System.Drawing.Size(53, 20);
            this.labCT.TabIndex = 16;
            this.labCT.Text = "label1";
            // 
            // labWTE
            // 
            this.labWTE.AutoSize = true;
            this.labWTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWTE.Location = new System.Drawing.Point(1197, 386);
            this.labWTE.Name = "labWTE";
            this.labWTE.Size = new System.Drawing.Size(53, 20);
            this.labWTE.TabIndex = 17;
            this.labWTE.Text = "label1";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.Location = new System.Drawing.Point(1037, 339);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(113, 20);
            this.labCrustType.TabIndex = 18;
            this.labCrustType.Text = "Crust Type :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 554);
            this.Controls.Add(this.labCrustType);
            this.Controls.Add(this.labWTE);
            this.Controls.Add(this.labCT);
            this.Controls.Add(this.labTP);
            this.Controls.Add(this.labT);
            this.Controls.Add(this.labPS);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.labToppings);
            this.Controls.Add(this.labPizzaSize);
            this.Controls.Add(this.labOrderSummary);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.labWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbPizzaSize);
            this.Controls.Add(this.labTitleName);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitleName;
        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chbExtraChees;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbGreenPeppers;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label labOrderSummary;
        private System.Windows.Forms.Label labPizzaSize;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label labPS;
        private System.Windows.Forms.Label labT;
        private System.Windows.Forms.Label labTP;
        private System.Windows.Forms.Label labCT;
        private System.Windows.Forms.Label labWTE;
        private System.Windows.Forms.Label labCrustType;
    }
}

