using System;
using System.Windows.Forms;
using CargoLiftingDevices;

namespace CargoLiftingDevicesProject
{
  /// <summary>
  /// Lever screw jack form
  /// </summary>
  public partial class LeverScrewJackForm : Form
  {
    /// <summary>
    /// Operating mode
    /// </summary>
    private CargoLiftingDevicesForm.OperatingMode _operatingMode;
    /// <summary>
    /// Lever screw jack
    /// </summary>
    public LeverScrewJack _leverScrewJack { get; set; } = null;
    /// <summary>
    /// oCnstructor
    /// </summary>
    /// <param name="parOperatingMode">operating mode</param>
    public LeverScrewJackForm(CargoLiftingDevicesForm.OperatingMode parOperatingMode)
    {
      InitializeComponent();
      this._operatingMode = parOperatingMode;
    }
    /// <summary>
    /// Lever screw jack form load handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LeverScrewJackForm_Load(object sender, EventArgs e)
    {
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Add)
      {
        buttonAction.Text = CargoLiftingDevicesForm.ADD_MODE_BUTTON_NAME;
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Change)
      {
        buttonAction.Text = CargoLiftingDevicesForm.CHANGE_MODE_BUTTON_NAME;
        textBoxName.Text = _leverScrewJack.Name;
        numericUpDownCarryingCapacity.Value = _leverScrewJack.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _leverScrewJack.LiftingHeight;
        numericUpDownPickupHeight.Value = _leverScrewJack.PickupHeight;
        numericUpDownWorkingStrokeRod.Value = _leverScrewJack.WorkingStrokeRod;
        textBoxNumberScrewRibs.Text = Convert.ToString(_leverScrewJack.NumberScrewRibs);
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Delete)
      {
        buttonAction.Text = CargoLiftingDevicesForm.DELETE_MODE_BUTTON_NAME;
        textBoxName.Text = _leverScrewJack.Name;
        numericUpDownCarryingCapacity.Value = _leverScrewJack.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _leverScrewJack.LiftingHeight;
        numericUpDownPickupHeight.Value = _leverScrewJack.PickupHeight;
        numericUpDownWorkingStrokeRod.Value = _leverScrewJack.WorkingStrokeRod;
        textBoxNumberScrewRibs.Text = Convert.ToString(_leverScrewJack.NumberScrewRibs);
        textBoxName.Enabled = false;
        numericUpDownCarryingCapacity.Enabled = false;
        numericUpDownLiftingHeight.Enabled = false;
        numericUpDownPickupHeight.Enabled = false;
        numericUpDownWorkingStrokeRod.Enabled = false;
        textBoxNumberScrewRibs.Enabled = false;
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
        int typeRotation = int.Parse(textBoxNumberScrewRibs.Text);
        LeverScrewJack leverScrewJack = new LeverScrewJack(name, carryingCapacity, liftingHeight, pickupHeight, workingStrokeRod, typeRotation);
        this._leverScrewJack = leverScrewJack;
      }
    }
  }
}
