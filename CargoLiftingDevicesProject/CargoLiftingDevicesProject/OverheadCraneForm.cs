using System;
using System.Windows.Forms;
using CargoLiftingDevices;

namespace CargoLiftingDevicesProject
{
  /// <summary>
  /// Overhead crane form
  /// </summary>
  public partial class OverheadCraneForm : Form
  {
    /// <summary>
    /// Operating mode
    /// </summary>
    private CargoLiftingDevicesForm.OperatingMode _operatingMode;
    /// <summary>
    /// Overhead crane
    /// </summary>
    public OverheadCrane _overheadCrane { get; set; } = null;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parOperatingMode">operating mode</param>
    public OverheadCraneForm(CargoLiftingDevicesForm.OperatingMode parOperatingMode)
    {
      InitializeComponent();
      this._operatingMode = parOperatingMode;
    }
    /// <summary>
    /// Button action click handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonAction_Click(object sender, EventArgs e)
    {
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Add || _operatingMode == CargoLiftingDevicesForm.OperatingMode.Change)
      {
        string name = textBoxName.Text;
        int carryingCapacity = Convert.ToInt32(numericUpDownCarryingCapacity.Value);
        int liftingHeight = Convert.ToInt32(numericUpDownLiftingHeight.Value);
        int craneBoomLength = Convert.ToInt32(numericUpDownCraneBoomLength.Value);
        string driveType = comboBoxDriveType.Text;
        OverheadCrane overheadCrane = new OverheadCrane(name, carryingCapacity, liftingHeight, craneBoomLength, driveType);
        this._overheadCrane = overheadCrane;
      }
    }
    /// <summary>
    /// Overhead crane form load handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OverheadCraneForm_Load(object sender, EventArgs e)
    {
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Add)
      {
        buttonAction.Text = CargoLiftingDevicesForm.ADD_MODE_BUTTON_NAME;
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Change)
      {
        buttonAction.Text = CargoLiftingDevicesForm.CHANGE_MODE_BUTTON_NAME;
        textBoxName.Text = _overheadCrane.Name;
        numericUpDownCarryingCapacity.Value = _overheadCrane.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _overheadCrane.LiftingHeight;
        numericUpDownCraneBoomLength.Value = _overheadCrane.CraneBoomLength;
        comboBoxDriveType.Text = Convert.ToString(_overheadCrane.DriveType);
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Delete)
      {
        buttonAction.Text = CargoLiftingDevicesForm.DELETE_MODE_BUTTON_NAME;
        textBoxName.Text = _overheadCrane.Name;
        numericUpDownCarryingCapacity.Value = _overheadCrane.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _overheadCrane.LiftingHeight;
        numericUpDownCraneBoomLength.Value = _overheadCrane.CraneBoomLength;
        comboBoxDriveType.Text = Convert.ToString(_overheadCrane.DriveType);
        textBoxName.Enabled = false;
        numericUpDownCarryingCapacity.Enabled = false;
        numericUpDownLiftingHeight.Enabled = false;
        numericUpDownCraneBoomLength.Enabled = false;
        comboBoxDriveType.Enabled = false;
      }
    }
  }
}
