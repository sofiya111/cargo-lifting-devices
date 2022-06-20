using System;
using System.Windows.Forms;
using CargoLiftingDevices;

namespace CargoLiftingDevicesProject
{
  /// <summary>
  /// Rhombic jack form
  /// </summary>
  public partial class RhombicJackForm : Form
  {
    /// <summary>
    /// Operating mode
    /// </summary>
    private CargoLiftingDevicesForm.OperatingMode _operatingMode;
    /// <summary>
    /// Rhombic jack
    /// </summary>
    public RhombicJack _rhombicJack { get; set; } = null;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parOperatingMode">operating mode</param>
    public RhombicJackForm(CargoLiftingDevicesForm.OperatingMode parOperatingMode)
    {
      InitializeComponent();
      this._operatingMode = parOperatingMode;
    }
    /// <summary>
    /// Rhombic jack form load handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RhombicJackForm_Load(object sender, EventArgs e)
    {
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Add)
      {
        buttonAction.Text = CargoLiftingDevicesForm.ADD_MODE_BUTTON_NAME;
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Change)
      {
        buttonAction.Text = CargoLiftingDevicesForm.CHANGE_MODE_BUTTON_NAME;
        textBoxName.Text = _rhombicJack.Name;
        numericUpDownCarryingCapacity.Value = _rhombicJack.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _rhombicJack.LiftingHeight;
        numericUpDownPickupHeight.Value = _rhombicJack.PickupHeight;
        numericUpDownWorkingStrokeRod.Value = _rhombicJack.WorkingStrokeRod;
        comboBoxScrewDriveMethod.Text = _rhombicJack.ScrewDriveMethod;
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Delete)
      {
        buttonAction.Text = CargoLiftingDevicesForm.DELETE_MODE_BUTTON_NAME;
        textBoxName.Text = _rhombicJack.Name;
        numericUpDownCarryingCapacity.Value = _rhombicJack.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _rhombicJack.LiftingHeight;
        numericUpDownPickupHeight.Value = _rhombicJack.PickupHeight;
        numericUpDownWorkingStrokeRod.Value = _rhombicJack.WorkingStrokeRod;
        comboBoxScrewDriveMethod.Text = _rhombicJack.ScrewDriveMethod;
        textBoxName.Enabled = false;
        numericUpDownCarryingCapacity.Enabled = false;
        numericUpDownLiftingHeight.Enabled = false;
        numericUpDownPickupHeight.Enabled = false;
        numericUpDownWorkingStrokeRod.Enabled = false;
        comboBoxScrewDriveMethod.Enabled = false;
      }
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
        int pickupHeight = Convert.ToInt32(numericUpDownPickupHeight.Value);
        int workingStrokeRod = Convert.ToInt32(numericUpDownWorkingStrokeRod.Value);
        string screwDriveMethod = comboBoxScrewDriveMethod.Text;
        RhombicJack rhombicJack = new RhombicJack(name, carryingCapacity, liftingHeight, pickupHeight, workingStrokeRod, screwDriveMethod);
        this._rhombicJack = rhombicJack;
      }
    }
  }
}
