using System;

namespace GameStore.WebUI.Models
{
    public class PagingInfo
    {
        // Кількість товарів
        public int TotalItems { get; set; }

        // Кількість товарів на одній сторінці
        public int ItemsPerPage { get; set; }

        // Номер сторінки
        public int CurrentPage { get; set; }

        // Кількість сторінок
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}