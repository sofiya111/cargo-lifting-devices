using System;
using System.Windows.Forms;
using CargoLiftingDevices;

namespace CargoLiftingDevicesProject
{
  /// <summary>
  /// Bottle jack form
  /// </summary>
  public partial class BottleJackForm : Form
  {
    /// <summary>
    /// Operating mode
    /// </summary>
    private CargoLiftingDevicesForm.OperatingMode _operatingMode;
    /// <summary>
    /// Bottle jack
    /// </summary>
    public BottleJack _bottleJack { get; set; } = null;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parOperatingMode">operating mode</param>
    public BottleJackForm(CargoLiftingDevicesForm.OperatingMode parOperatingMode)
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
        int pickupHeight = Convert.ToInt32(numericUpDownPickupHeight.Value);
        int workingStrokeRod = Convert.ToInt32(numericUpDownWorkingStrokeRod.Value);
        string typeRotation = comboBoxTypeRotation.Text;
        BottleJack bottleJack = new BottleJack(name, carryingCapacity, liftingHeight, pickupHeight, workingStrokeRod, typeRotation);
        this._bottleJack = bottleJack;
      }
    }
    /// <summary>
    /// Bottle jack form load handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BottleJackForm_Load(object sender, EventArgs e)
    {
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Add)
      {
        buttonAction.Text = CargoLiftingDevicesForm.ADD_MODE_BUTTON_NAME;
      }
        if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Change)
      {
        buttonAction.Text = CargoLiftingDevicesForm.CHANGE_MODE_BUTTON_NAME;
        textBoxName.Text = _bottleJack.Name;
        numericUpDownCarryingCapacity.Value = _bottleJack.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _bottleJack.LiftingHeight;
        numericUpDownPickupHeight.Value = _bottleJack.PickupHeight;
        numericUpDownWorkingStrokeRod.Value = _bottleJack.WorkingStrokeRod;
        comboBoxTypeRotation.Text = _bottleJack.TypeRotation;
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Delete)
      {
        buttonAction.Text = CargoLiftingDevicesForm.DELETE_MODE_BUTTON_NAME;
        textBoxName.Text = _bottleJack.Name;
        numericUpDownCarryingCapacity.Value = _bottleJack.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _bottleJack.LiftingHeight;
        numericUpDownPickupHeight.Value = _bottleJack.PickupHeight;
        numericUpDownWorkingStrokeRod.Value = _bottleJack.WorkingStrokeRod;
        comboBoxTypeRotation.Text = _bottleJack.TypeRotation;
        textBoxName.Enabled = false;
        numericUpDownCarryingCapacity.Enabled = false;
        numericUpDownLiftingHeight.Enabled = false;
        numericUpDownPickupHeight.Enabled = false;
        numericUpDownWorkingStrokeRod.Enabled = false;
        comboBoxTypeRotation.Enabled = false;
      }
    }
  }
}
