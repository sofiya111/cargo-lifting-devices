using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLiftingDevices
{
  /// <summary>
  /// Бутылочный домкрат
  /// </summary>
  public class BottleJack : Jack
  {
    /// <summary>
    /// Тип вращения
    /// </summary>
    private string _typeRotation;
    /// <summary>
    /// Тип вращения
    /// </summary>
    public string TypeRotation
    {
      get
      {
        return _typeRotation;
      }
      set
      {
        _typeRotation = value;
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
    /// <param name="parTypeRotation">Тип вращения</param>    
    public BottleJack(string parName, int parCarryingCapacity, int parLiftingHeight, int parPickupHeight, int parWorkingStrokeRod, string parTypeRotation) :
        base(parName, parCarryingCapacity, parLiftingHeight, parPickupHeight, parWorkingStrokeRod)
    {
      _typeRotation = parTypeRotation;
    }
  }
}
