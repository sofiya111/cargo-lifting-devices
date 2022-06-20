using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLiftingDevices
{
  /// <summary>
  /// Стреловой кран
  /// </summary>
  public class JibCrane : Crane
  {
    /// <summary>
    /// Исполнение подвески стрелового оборудования
    /// </summary>
    private string _jibEquipmentSuspensionDesign;
    /// <summary>
    /// Исполнение подвески стрелового оборудования
    /// </summary>
    public string JibEquipmentSuspensionDesign
    {
      get
      {
        return _jibEquipmentSuspensionDesign;
      }
      set
      {
        _jibEquipmentSuspensionDesign = value;
      }
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parName">Название устройства для подъема груза</param>
    /// <param name="parCarryingCapacity">Грузоподъемность</param>
    /// <param name="parLiftingHeight">Высота подъема</param>
    /// <param name="parCraneBoomLength">Длина стрелы крана</param>
    /// <param name="parJibEquipmentSuspensionDesign">Исполнение подвески стрелового оборудования</param>
    public JibCrane(string parName, int parCarryingCapacity, int parLiftingHeight, int parCraneBoomLength, string parJibEquipmentSuspensionDesign) :
        base(parName, parCarryingCapacity, parLiftingHeight, parCraneBoomLength)
    {
      _jibEquipmentSuspensionDesign = parJibEquipmentSuspensionDesign;
    }
  }
}
