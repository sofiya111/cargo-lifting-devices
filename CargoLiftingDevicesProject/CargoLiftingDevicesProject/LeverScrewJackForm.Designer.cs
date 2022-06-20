
namespace CargoLiftingDevicesProject
{
  partial class LeverScrewJackForm
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
      this.buttonCancel = new System.Windows.Forms.Button();
      this.buttonAction = new System.Windows.Forms.Button();
      this.labelNumberScrewRibs = new System.Windows.Forms.Label();
      this.labelWorkingStrokeRod = new System.Windows.Forms.Label();
      this.labelPickupHeight = new System.Windows.Forms.Label();
      this.labelLiftingHeight = new System.Windows.Forms.Label();
      this.labelCarryingCapacity = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.labelName = new System.Windows.Forms.Label();
      this.textBoxNumberScrewRibs = new System.Windows.Forms.TextBox();
      this.numericUpDownWorkingStrokeRod = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownPickupHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLiftingHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownCarryingCapacity = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingStrokeRod)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickupHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(275, 338);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(116, 35);
      this.buttonCancel.TabIndex = 27;
      this.buttonCancel.Text = "Отмена";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // buttonAction
      // 
      this.buttonAction.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAction.Location = new System.Drawing.Point(104, 338);
      this.buttonAction.Name = "buttonAction";
      this.buttonAction.Size = new System.Drawing.Size(116, 35);
      this.buttonAction.TabIndex = 26;
      this.buttonAction.Text = "button";
      this.buttonAction.UseVisualStyleBackColor = true;
      this.buttonAction.Click += new System.EventHandler(this.ButtonAction_Click);
      // 
      // labelNumberScrewRibs
      // 
      this.labelNumberScrewRibs.AutoSize = true;
      this.labelNumberScrewRibs.Location = new System.Drawing.Point(75, 263);
      this.labelNumberScrewRibs.Name = "labelNumberScrewRibs";
      this.labelNumberScrewRibs.Size = new System.Drawing.Size(172, 17);
      this.labelNumberScrewRibs.TabIndex = 24;
      this.labelNumberScrewRibs.Text = "Количество ребер винта";
      // 
      // labelWorkingStrokeRod
      // 
      this.labelWorkingStrokeRod.AutoSize = true;
      this.labelWorkingStrokeRod.Location = new System.Drawing.Point(75, 220);
      this.labelWorkingStrokeRod.Name = "labelWorkingStrokeRod";
      this.labelWorkingStrokeRod.Size = new System.Drawing.Size(136, 17);
      this.labelWorkingStrokeRod.TabIndex = 22;
      this.labelWorkingStrokeRod.Text = "Рабочий ход штока";
      // 
      // labelPickupHeight
      // 
      this.labelPickupHeight.AutoSize = true;
      this.labelPickupHeight.Location = new System.Drawing.Point(75, 183);
      this.labelPickupHeight.Name = "labelPickupHeight";
      this.labelPickupHeight.Size = new System.Drawing.Size(121, 17);
      this.labelPickupHeight.TabIndex = 20;
      this.labelPickupHeight.Text = "Высота подхвата";
      // 
      // labelLiftingHeight
      // 
      this.labelLiftingHeight.AutoSize = true;
      this.labelLiftingHeight.Location = new System.Drawing.Point(75, 145);
      this.labelLiftingHeight.Name = "labelLiftingHeight";
      this.labelLiftingHeight.Size = new System.Drawing.Size(119, 17);
      this.labelLiftingHeight.TabIndex = 18;
      this.labelLiftingHeight.Text = "Высота подъема";
      // 
      // labelCarryingCapacity
      // 
      this.labelCarryingCapacity.AutoSize = true;
      this.labelCarryingCapacity.Location = new System.Drawing.Point(75, 105);
      this.labelCarryingCapacity.Name = "labelCarryingCapacity";
      this.labelCarryingCapacity.Size = new System.Drawing.Size(133, 17);
      this.labelCarryingCapacity.TabIndex = 16;
      this.labelCarryingCapacity.Text = "Грузоподъемность";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(253, 66);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(167, 22);
      this.textBoxName.TabIndex = 15;
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(75, 66);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(72, 17);
      this.labelName.TabIndex = 14;
      this.labelName.Text = "Название";
      // 
      // textBoxNumberScrewRibs
      // 
      this.textBoxNumberScrewRibs.Location = new System.Drawing.Point(253, 260);
      this.textBoxNumberScrewRibs.Name = "textBoxNumberScrewRibs";
      this.textBoxNumberScrewRibs.Size = new System.Drawing.Size(167, 22);
      this.textBoxNumberScrewRibs.TabIndex = 28;
      // 
      // numericUpDownWorkingStrokeRod
      // 
      this.numericUpDownWorkingStrokeRod.Location = new System.Drawing.Point(253, 220);
      this.numericUpDownWorkingStrokeRod.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownWorkingStrokeRod.Name = "numericUpDownWorkingStrokeRod";
      this.numericUpDownWorkingStrokeRod.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownWorkingStrokeRod.TabIndex = 32;
      // 
      // numericUpDownPickupHeight
      // 
      this.numericUpDownPickupHeight.Location = new System.Drawing.Point(253, 183);
      this.numericUpDownPickupHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownPickupHeight.Name = "numericUpDownPickupHeight";
      this.numericUpDownPickupHeight.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownPickupHeight.TabIndex = 31;
      // 
      // numericUpDownLiftingHeight
      // 
      this.numericUpDownLiftingHeight.Location = new System.Drawing.Point(253, 145);
      this.numericUpDownLiftingHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownLiftingHeight.Name = "numericUpDownLiftingHeight";
      this.numericUpDownLiftingHeight.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownLiftingHeight.TabIndex = 30;
      // 
      // numericUpDownCarryingCapacity
      // 
      this.numericUpDownCarryingCapacity.Location = new System.Drawing.Point(253, 105);
      this.numericUpDownCarryingCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownCarryingCapacity.Name = "numericUpDownCarryingCapacity";
      this.numericUpDownCarryingCapacity.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownCarryingCapacity.TabIndex = 29;
      // 
      // LeverScrewJackForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(483, 435);
      this.Controls.Add(this.numericUpDownWorkingStrokeRod);
      this.Controls.Add(this.numericUpDownPickupHeight);
      this.Controls.Add(this.numericUpDownLiftingHeight);
      this.Controls.Add(this.numericUpDownCarryingCapacity);
      this.Controls.Add(this.textBoxNumberScrewRibs);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAction);
      this.Controls.Add(this.labelNumberScrewRibs);
      this.Controls.Add(this.labelWorkingStrokeRod);
      this.Controls.Add(this.labelPickupHeight);
      this.Controls.Add(this.labelLiftingHeight);
      this.Controls.Add(this.labelCarryingCapacity);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelName);
      this.MaximumSize = new System.Drawing.Size(501, 482);
      this.MinimumSize = new System.Drawing.Size(501, 482);
      this.Name = "LeverScrewJackForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LeverScrewJackForm";
      this.Load += new System.EventHandler(this.LeverScrewJackForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingStrokeRod)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickupHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonAction;
    private System.Windows.Forms.Label labelNumberScrewRibs;
    private System.Windows.Forms.Label labelWorkingStrokeRod;
    private System.Windows.Forms.Label labelPickupHeight;
    private System.Windows.Forms.Label labelLiftingHeight;
    private System.Windows.Forms.Label labelCarryingCapacity;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.TextBox textBoxNumberScrewRibs;
    private System.Windows.Forms.NumericUpDown numericUpDownWorkingStrokeRod;
    private System.Windows.Forms.NumericUpDown numericUpDownPickupHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownLiftingHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownCarryingCapacity;
  }
}