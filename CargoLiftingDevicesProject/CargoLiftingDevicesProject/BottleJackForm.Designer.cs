
namespace CargoLiftingDevicesProject
{
  partial class BottleJackForm
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
      this.labelName = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.labelCarryingCapacity = new System.Windows.Forms.Label();
      this.labelLiftingHeight = new System.Windows.Forms.Label();
      this.labelPickupHeight = new System.Windows.Forms.Label();
      this.labelWorkingStrokeRod = new System.Windows.Forms.Label();
      this.labelTypeRotation = new System.Windows.Forms.Label();
      this.comboBoxTypeRotation = new System.Windows.Forms.ComboBox();
      this.buttonAction = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.numericUpDownCarryingCapacity = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLiftingHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownPickupHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownWorkingStrokeRod = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickupHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingStrokeRod)).BeginInit();
      this.SuspendLayout();
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(71, 46);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(72, 17);
      this.labelName.TabIndex = 0;
      this.labelName.Text = "Название";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(210, 46);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(167, 22);
      this.textBoxName.TabIndex = 1;
      // 
      // labelCarryingCapacity
      // 
      this.labelCarryingCapacity.AutoSize = true;
      this.labelCarryingCapacity.Location = new System.Drawing.Point(71, 85);
      this.labelCarryingCapacity.Name = "labelCarryingCapacity";
      this.labelCarryingCapacity.Size = new System.Drawing.Size(133, 17);
      this.labelCarryingCapacity.TabIndex = 2;
      this.labelCarryingCapacity.Text = "Грузоподъемность";
      // 
      // labelLiftingHeight
      // 
      this.labelLiftingHeight.AutoSize = true;
      this.labelLiftingHeight.Location = new System.Drawing.Point(71, 125);
      this.labelLiftingHeight.Name = "labelLiftingHeight";
      this.labelLiftingHeight.Size = new System.Drawing.Size(119, 17);
      this.labelLiftingHeight.TabIndex = 4;
      this.labelLiftingHeight.Text = "Высота подъема";
      // 
      // labelPickupHeight
      // 
      this.labelPickupHeight.AutoSize = true;
      this.labelPickupHeight.Location = new System.Drawing.Point(71, 163);
      this.labelPickupHeight.Name = "labelPickupHeight";
      this.labelPickupHeight.Size = new System.Drawing.Size(121, 17);
      this.labelPickupHeight.TabIndex = 6;
      this.labelPickupHeight.Text = "Высота подхвата";
      // 
      // labelWorkingStrokeRod
      // 
      this.labelWorkingStrokeRod.AutoSize = true;
      this.labelWorkingStrokeRod.Location = new System.Drawing.Point(71, 200);
      this.labelWorkingStrokeRod.Name = "labelWorkingStrokeRod";
      this.labelWorkingStrokeRod.Size = new System.Drawing.Size(136, 17);
      this.labelWorkingStrokeRod.TabIndex = 8;
      this.labelWorkingStrokeRod.Text = "Рабочий ход штока";
      // 
      // labelTypeRotation
      // 
      this.labelTypeRotation.AutoSize = true;
      this.labelTypeRotation.Location = new System.Drawing.Point(71, 243);
      this.labelTypeRotation.Name = "labelTypeRotation";
      this.labelTypeRotation.Size = new System.Drawing.Size(103, 17);
      this.labelTypeRotation.TabIndex = 10;
      this.labelTypeRotation.Text = "Тип вращения";
      // 
      // comboBoxTypeRotation
      // 
      this.comboBoxTypeRotation.FormattingEnabled = true;
      this.comboBoxTypeRotation.Items.AddRange(new object[] {
            "по часовой стрелке",
            "против часовой стрелки"});
      this.comboBoxTypeRotation.Location = new System.Drawing.Point(210, 240);
      this.comboBoxTypeRotation.Name = "comboBoxTypeRotation";
      this.comboBoxTypeRotation.Size = new System.Drawing.Size(167, 24);
      this.comboBoxTypeRotation.TabIndex = 11;
      // 
      // buttonAction
      // 
      this.buttonAction.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAction.Location = new System.Drawing.Point(88, 329);
      this.buttonAction.Name = "buttonAction";
      this.buttonAction.Size = new System.Drawing.Size(116, 35);
      this.buttonAction.TabIndex = 12;
      this.buttonAction.Text = "button";
      this.buttonAction.UseVisualStyleBackColor = true;
      this.buttonAction.Click += new System.EventHandler(this.ButtonAction_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(235, 329);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(116, 35);
      this.buttonCancel.TabIndex = 13;
      this.buttonCancel.Text = "Отмена";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // numericUpDownCarryingCapacity
      // 
      this.numericUpDownCarryingCapacity.Location = new System.Drawing.Point(210, 85);
      this.numericUpDownCarryingCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownCarryingCapacity.Name = "numericUpDownCarryingCapacity";
      this.numericUpDownCarryingCapacity.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownCarryingCapacity.TabIndex = 14;
      // 
      // numericUpDownLiftingHeight
      // 
      this.numericUpDownLiftingHeight.Location = new System.Drawing.Point(210, 125);
      this.numericUpDownLiftingHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownLiftingHeight.Name = "numericUpDownLiftingHeight";
      this.numericUpDownLiftingHeight.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownLiftingHeight.TabIndex = 15;
      // 
      // numericUpDownPickupHeight
      // 
      this.numericUpDownPickupHeight.Location = new System.Drawing.Point(210, 163);
      this.numericUpDownPickupHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownPickupHeight.Name = "numericUpDownPickupHeight";
      this.numericUpDownPickupHeight.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownPickupHeight.TabIndex = 16;
      // 
      // numericUpDownWorkingStrokeRod
      // 
      this.numericUpDownWorkingStrokeRod.Location = new System.Drawing.Point(210, 200);
      this.numericUpDownWorkingStrokeRod.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownWorkingStrokeRod.Name = "numericUpDownWorkingStrokeRod";
      this.numericUpDownWorkingStrokeRod.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownWorkingStrokeRod.TabIndex = 17;
      // 
      // BottleJackForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(453, 432);
      this.Controls.Add(this.numericUpDownWorkingStrokeRod);
      this.Controls.Add(this.numericUpDownPickupHeight);
      this.Controls.Add(this.numericUpDownLiftingHeight);
      this.Controls.Add(this.numericUpDownCarryingCapacity);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAction);
      this.Controls.Add(this.comboBoxTypeRotation);
      this.Controls.Add(this.labelTypeRotation);
      this.Controls.Add(this.labelWorkingStrokeRod);
      this.Controls.Add(this.labelPickupHeight);
      this.Controls.Add(this.labelLiftingHeight);
      this.Controls.Add(this.labelCarryingCapacity);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelName);
      this.MaximumSize = new System.Drawing.Size(471, 479);
      this.MinimumSize = new System.Drawing.Size(471, 479);
      this.Name = "BottleJackForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "BottleJackForm";
      this.Load += new System.EventHandler(this.BottleJackForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickupHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingStrokeRod)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label labelCarryingCapacity;
    private System.Windows.Forms.Label labelLiftingHeight;
    private System.Windows.Forms.Label labelPickupHeight;
    private System.Windows.Forms.Label labelWorkingStrokeRod;
    private System.Windows.Forms.Label labelTypeRotation;
    private System.Windows.Forms.ComboBox comboBoxTypeRotation;
    private System.Windows.Forms.Button buttonAction;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.NumericUpDown numericUpDownCarryingCapacity;
    private System.Windows.Forms.NumericUpDown numericUpDownLiftingHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownPickupHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownWorkingStrokeRod;
  }
}