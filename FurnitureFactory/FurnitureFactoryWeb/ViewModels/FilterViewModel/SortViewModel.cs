using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureFactoryWeb.ViewModels.FilterViewModel
{
    public enum SortState
    {
        No, // не сортировать
        AddressAsc,    // по адресу клиента по возрастанию
        AddressDesc,   // по адресу клиента по убыванию
        SurnameAsc, // по фамилии сотрудника gj возрастанию
        SurnameDesc,    // по фамилии сотрудника по убыванию

    }
    public class SortViewModel
    {
        public SortState CurrentState { get; set; }     // текущее значение сортировки
        public SortState CustomerAddressSort { get; set; } // значение для сортировки по адресу
        public SortState EmployeeSurnameSort { get; set; }    // значение для сортировки по фамилии

        public SortViewModel(SortState sortOrder)
        {
            CustomerAddressSort = sortOrder == SortState.AddressAsc ? SortState.AddressDesc : SortState.AddressAsc;
            EmployeeSurnameSort = sortOrder == SortState.SurnameAsc ? SortState.SurnameDesc : SortState.SurnameAsc;
            CurrentState = sortOrder;
        }



    }
}
