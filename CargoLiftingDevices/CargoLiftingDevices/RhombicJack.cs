using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLiftingDevices
{
  /// <summary>
  /// Ромбический домкрат
  /// </summary>
  public class RhombicJack : Jack
  {
    /// <summary>
    /// Способ привода винта
    /// </summary>
    private string _screwDriveMethod;
    /// <summary>
    /// Способ привода винта
    /// </summary>
    public string ScrewDriveMethod
    {
      get
      {
        return _screwDriveMethod;
      }
      set
      {
        _screwDriveMethod = value;
      }
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parName">Название устройства для подъема груза</param>
    /// <param name="parCarryingCapacity">Грузоподъемность</param>
    /// <param name="parLiftingHeight">Высота подъема</param>
    /// <param name="parPickupHeight">Высота подхвата</param>
    /// <param name="parWorkingStrokeRod">Рабочий ход штока</param>
    /// <param name="parScrewDriveMethod">Способ привода винта</param>
    public RhombicJack(string parName, int parCarryingCapacity, int parLiftingHeight, int parPickupHeight, int parWorkingStrokeRod, string parScrewDriveMethod) :
        base(parName, parCarryingCapacity, parLiftingHeight, parPickupHeight, parWorkingStrokeRod)
    {
      _screwDriveMethod = parScrewDriveMethod;
    }
  }
}
