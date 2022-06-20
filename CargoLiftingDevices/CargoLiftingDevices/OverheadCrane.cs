using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLiftingDevices
{
  /// <summary>
  /// Мостовой кран
  /// </summary>
  public class OverheadCrane : Crane
  {
    /// <summary>
    /// Вид привода 
    /// </summary>
    private string _driveType;
    /// <summary>
    /// Вид привода 
    /// </summary>
    public string DriveType
    {
      get
      {
        return _driveType;
      }
      set
      {
        _driveType = value;
      }
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parName">Название устройства для подъема груза</param>
    /// <param name="parCarryingCapacity">Грузоподъемность</param>
    /// <param name="parLiftingHeight">Высота подъема</param>
    /// <param name="parCraneBoomLength">Длина стрелы крана</param>
    /// <param name="parDriveType">Вид привода</param>
    public OverheadCrane(string parName, int parCarryingCapacity, int parLiftingHeight, int parCraneBoomLength, string parDriveType) :
        base(parName, parCarryingCapacity, parLiftingHeight, parCraneBoomLength)
    {
      _driveType = parDriveType;
    }
  }
}
