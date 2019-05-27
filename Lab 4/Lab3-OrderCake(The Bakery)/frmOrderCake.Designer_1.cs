namespace Lab3_OrderCake_The_Bakery_
{
    partial class frmOrderCake
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
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCakeType = new System.Windows.Forms.GroupBox();
            this.radTraditional = new System.Windows.Forms.RadioButton();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.lblChooseCake = new System.Windows.Forms.Label();
            this.lstChooseCake = new System.Windows.Forms.ListBox();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.grpCustomCake = new System.Windows.Forms.GroupBox();
            this.grpNumTiers = new System.Windows.Forms.GroupBox();
            this.rad3Tiers = new System.Windows.Forms.RadioButton();
            this.rad2Tiers = new System.Windows.Forms.RadioButton();
            this.rad1Tier = new System.Windows.Forms.RadioButton();
            this.grpOccasion = new System.Windows.Forms.GroupBox();
            this.radWedding = new System.Windows.Forms.RadioButton();
            this.radGraduation = new System.Windows.Forms.RadioButton();
            this.radAnniversary = new System.Windows.Forms.RadioButton();
            this.grpFlavour = new System.Windows.Forms.GroupBox();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.radVanilla = new System.Windows.Forms.RadioButton();
            this.radChocolate = new System.Windows.Forms.RadioButton();
            this.grpCakeType.SuspendLayout();
            this.grpCustomCake.SuspendLayout();
            this.grpNumTiers.SuspendLayout();
            this.grpOccasion.SuspendLayout();
            this.grpFlavour.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(10, 312);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(86, 37);
            this.btnAddCart.TabIndex = 2;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(355, 314);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(438, 314);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "The Bakery";
            // 
            // grpCakeType
            // 
            this.grpCakeType.Controls.Add(this.radTraditional);
            this.grpCakeType.Controls.Add(this.radCustom);
            this.grpCakeType.Location = new System.Drawing.Point(23, 50);
            this.grpCakeType.Name = "grpCakeType";
            this.grpCakeType.Size = new System.Drawing.Size(211, 57);
            this.grpCakeType.TabIndex = 13;
            this.grpCakeType.TabStop = false;
            this.grpCakeType.Text = "Type of Cake";
            // 
            // radTraditional
            // 
            this.radTraditional.Location = new System.Drawing.Point(113, 18);
            this.radTraditional.Name = "radTraditional";
            this.radTraditional.Size = new System.Drawing.Size(92, 34);
            this.radTraditional.TabIndex = 1;
            this.radTraditional.TabStop = true;
            this.radTraditional.Text = "&Traditional";
            this.radTraditional.UseVisualStyleBackColor = true;
            this.radTraditional.CheckedChanged += new System.EventHandler(this.radTraditional_CheckedChanged);
            // 
            // radCustom
            // 
            this.radCustom.Checked = true;
            this.radCustom.Location = new System.Drawing.Point(26, 18);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(74, 34);
            this.radCustom.TabIndex = 0;
            this.radCustom.TabStop = true;
            this.radCustom.Text = "&Custom";
            this.radCustom.UseVisualStyleBackColor = true;
            this.radCustom.CheckedChanged += new System.EventHandler(this.radCustom_CheckedChanged);
            // 
            // lblChooseCake
            // 
            this.lblChooseCake.AutoSize = true;
            this.lblChooseCake.Location = new System.Drawing.Point(323, 50);
            this.lblChooseCake.Name = "lblChooseCake";
            this.lblChooseCake.Size = new System.Drawing.Size(107, 16);
            this.lblChooseCake.TabIndex = 14;
            this.lblChooseCake.Text = "Traditional Cake";
            // 
            // lstChooseCake
            // 
            this.lstChooseCake.FormattingEnabled = true;
            this.lstChooseCake.ItemHeight = 16;
            this.lstChooseCake.Items.AddRange(new object[] {
            "Strawberry Cheese Cake",
            "Lemon Velvet Cake",
            "Blueberry Mousse",
            "Tiramisu"});
            this.lstChooseCake.Location = new System.Drawing.Point(276, 69);
            this.lstChooseCake.Name = "lstChooseCake";
            this.lstChooseCake.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstChooseCake.Size = new System.Drawing.Size(154, 68);
            this.lstChooseCake.TabIndex = 16;
            // 
            // btnViewCart
            // 
            this.btnViewCart.Location = new System.Drawing.Point(103, 312);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(78, 37);
            this.btnViewCart.TabIndex = 17;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(187, 312);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(79, 37);
            this.btnClearCart.TabIndex = 18;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(272, 314);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(76, 35);
            this.btnCheckOut.TabIndex = 19;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // grpCustomCake
            // 
            this.grpCustomCake.Controls.Add(this.grpNumTiers);
            this.grpCustomCake.Controls.Add(this.grpOccasion);
            this.grpCustomCake.Controls.Add(this.grpFlavour);
            this.grpCustomCake.Location = new System.Drawing.Point(11, 143);
            this.grpCustomCake.Name = "grpCustomCake";
            this.grpCustomCake.Size = new System.Drawing.Size(467, 144);
            this.grpCustomCake.TabIndex = 20;
            this.grpCustomCake.TabStop = false;
            this.grpCustomCake.Text = "Custom Cake";
            // 
            // grpNumTiers
            // 
            this.grpNumTiers.Controls.Add(this.rad3Tiers);
            this.grpNumTiers.Controls.Add(this.rad2Tiers);
            this.grpNumTiers.Controls.Add(this.rad1Tier);
            this.grpNumTiers.Location = new System.Drawing.Point(307, 30);
            this.grpNumTiers.Name = "grpNumTiers";
            this.grpNumTiers.Size = new System.Drawing.Size(148, 100);
            this.grpNumTiers.TabIndex = 4;
            this.grpNumTiers.TabStop = false;
            this.grpNumTiers.Text = "Number of Tiers";
            // 
            // rad3Tiers
            // 
            this.rad3Tiers.AutoSize = true;
            this.rad3Tiers.Location = new System.Drawing.Point(6, 65);
            this.rad3Tiers.Name = "rad3Tiers";
            this.rad3Tiers.Size = new System.Drawing.Size(67, 20);
            this.rad3Tiers.TabIndex = 2;
            this.rad3Tiers.Text = "&3 Tiers";
            this.rad3Tiers.UseVisualStyleBackColor = true;
            // 
            // rad2Tiers
            // 
            this.rad2Tiers.AutoSize = true;
            this.rad2Tiers.Location = new System.Drawing.Point(6, 42);
            this.rad2Tiers.Name = "rad2Tiers";
            this.rad2Tiers.Size = new System.Drawing.Size(67, 20);
            this.rad2Tiers.TabIndex = 1;
            this.rad2Tiers.Text = "&2 Tiers";
            this.rad2Tiers.UseVisualStyleBackColor = true;
            // 
            // rad1Tier
            // 
            this.rad1Tier.AutoSize = true;
            this.rad1Tier.Checked = true;
            this.rad1Tier.Location = new System.Drawing.Point(6, 19);
            this.rad1Tier.Name = "rad1Tier";
            this.rad1Tier.Size = new System.Drawing.Size(60, 20);
            this.rad1Tier.TabIndex = 0;
            this.rad1Tier.TabStop = true;
            this.rad1Tier.Text = "&1 Tier";
            this.rad1Tier.UseVisualStyleBackColor = true;
            // 
            // grpOccasion
            // 
            this.grpOccasion.Controls.Add(this.radWedding);
            this.grpOccasion.Controls.Add(this.radGraduation);
            this.grpOccasion.Controls.Add(this.radAnniversary);
            this.grpOccasion.Location = new System.Drawing.Point(128, 30);
            this.grpOccasion.Name = "grpOccasion";
            this.grpOccasion.Size = new System.Drawing.Size(160, 100);
            this.grpOccasion.TabIndex = 3;
            this.grpOccasion.TabStop = false;
            this.grpOccasion.Text = "Occasion";
            // 
            // radWedding
            // 
            this.radWedding.AutoSize = true;
            this.radWedding.Location = new System.Drawing.Point(6, 65);
            this.radWedding.Name = "radWedding";
            this.radWedding.Size = new System.Drawing.Size(81, 20);
            this.radWedding.TabIndex = 2;
            this.radWedding.Text = "&Wedding";
            this.radWedding.UseVisualStyleBackColor = true;
            // 
            // radGraduation
            // 
            this.radGraduation.AutoSize = true;
            this.radGraduation.Location = new System.Drawing.Point(6, 42);
            this.radGraduation.Name = "radGraduation";
            this.radGraduation.Size = new System.Drawing.Size(92, 20);
            this.radGraduation.TabIndex = 1;
            this.radGraduation.Text = "&Graduation";
            this.radGraduation.UseVisualStyleBackColor = true;
            // 
            // radAnniversary
            // 
            this.radAnniversary.AutoSize = true;
            this.radAnniversary.Checked = true;
            this.radAnniversary.Location = new System.Drawing.Point(6, 19);
            this.radAnniversary.Name = "radAnniversary";
            this.radAnniversary.Size = new System.Drawing.Size(97, 20);
            this.radAnniversary.TabIndex = 0;
            this.radAnniversary.TabStop = true;
            this.radAnniversary.Text = "&Anniversary";
            this.radAnniversary.UseVisualStyleBackColor = true;
            // 
            // grpFlavour
            // 
            this.grpFlavour.Controls.Add(this.radBanana);
            this.grpFlavour.Controls.Add(this.radVanilla);
            this.grpFlavour.Controls.Add(this.radChocolate);
            this.grpFlavour.Location = new System.Drawing.Point(6, 30);
            this.grpFlavour.Name = "grpFlavour";
            this.grpFlavour.Size = new System.Drawing.Size(104, 100);
            this.grpFlavour.TabIndex = 0;
            this.grpFlavour.TabStop = false;
            this.grpFlavour.Text = "Flavour";
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(6, 65);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(73, 20);
            this.radBanana.TabIndex = 2;
            this.radBanana.Text = "&Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            this.radVanilla.AutoSize = true;
            this.radVanilla.Location = new System.Drawing.Point(6, 42);
            this.radVanilla.Name = "radVanilla";
            this.radVanilla.Size = new System.Drawing.Size(67, 20);
            this.radVanilla.TabIndex = 1;
            this.radVanilla.Text = "&Vanilla";
            this.radVanilla.UseVisualStyleBackColor = true;
            // 
            // radChocolate
            // 
            this.radChocolate.AutoSize = true;
            this.radChocolate.Checked = true;
            this.radChocolate.Location = new System.Drawing.Point(6, 19);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(87, 20);
            this.radChocolate.TabIndex = 0;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "&Chocolate";
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // frmOrderCake
            // 
            this.AcceptButton = this.btnAddCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(507, 372);
            this.Controls.Add(this.grpCustomCake);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.lstChooseCake);
            this.Controls.Add(this.lblChooseCake);
            this.Controls.Add(this.grpCakeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddCart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrderCake";
            this.Text = "Amrit Braich";
            this.grpCakeType.ResumeLayout(false);
            this.grpCustomCake.ResumeLayout(false);
            this.grpNumTiers.ResumeLayout(false);
            this.grpNumTiers.PerformLayout();
            this.grpOccasion.ResumeLayout(false);
            this.grpOccasion.PerformLayout();
            this.grpFlavour.ResumeLayout(false);
            this.grpFlavour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCakeType;
        private System.Windows.Forms.RadioButton radTraditional;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.Label lblChooseCake;
        private System.Windows.Forms.ListBox lstChooseCake;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.GroupBox grpCustomCake;
        private System.Windows.Forms.GroupBox grpNumTiers;
        private System.Windows.Forms.RadioButton rad3Tiers;
        private System.Windows.Forms.RadioButton rad2Tiers;
        private System.Windows.Forms.RadioButton rad1Tier;
        private System.Windows.Forms.GroupBox grpOccasion;
        private System.Windows.Forms.RadioButton radWedding;
        private System.Windows.Forms.RadioButton radGraduation;
        private System.Windows.Forms.RadioButton radAnniversary;
        private System.Windows.Forms.GroupBox grpFlavour;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.RadioButton radVanilla;
        private System.Windows.Forms.RadioButton radChocolate;
    }
}

