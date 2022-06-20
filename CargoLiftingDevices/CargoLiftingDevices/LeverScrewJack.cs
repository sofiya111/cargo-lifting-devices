using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLiftingDevices
{
  /// <summary>
  /// Рычажно-винтовой домкрат
  /// </summary>
  public class LeverScrewJack : Jack
  {
    /// <summary>
    /// Количество ребер винта
    /// </summary>
    private int _numberScrewRibs;
    /// <summary>
    /// Количество ребер винта
    /// </summary>
    public int NumberScrewRibs
    {
      get
      {
        return _numberScrewRibs;
      }
      set
      {
        _numberScrewRibs = value;
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
    /// <param name="parNumberScrewRibs">Количество ребер винта</param>
    public LeverScrewJack(string parName, int parCarryingCapacity, int parLiftingHeight, int parPickupHeight, int parWorkingStrokeRod, int parNumberScrewRibs) :
        base(parName, parCarryingCapacity, parLiftingHeight, parPickupHeight, parWorkingStrokeRod)
    {
      _numberScrewRibs = parNumberScrewRibs;
    }
  }
}
