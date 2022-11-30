using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNAeb
{
    public static class QueryGenerator
    {
        private static string _baseQuery;
        private static string _searchingCommand = "";
        private static string _sortingCommand = "";
        private static string _filterCommand = "";

        public static string GetLoginQuery()
        {
            return "select id, Логин, Пароль, Роль_сотрудника, Фамилия, Имя, Отчество from [user]";
        }

        public static string GetProductsQuery()
        {
            _baseQuery = "select Изображение, Наименование, Описание, Производитель, Стоимость, Кол_во_на_складе from products";

            return _baseQuery;
        }

        public static string GetSearchingQuery(string searchingString)
        {
            if (searchingString.Length == 0)
            {
                _searchingCommand = "";

                return GetProductsQuery();
            }

            _searchingCommand = $"Наименование like '{searchingString}%'"; 

            return GetResultQuery();
        }

        public static string GetFilterQuery(string filter)
        {
            _filterCommand = $"Производитель = '{filter}'";

            return GetResultQuery();
        }

        public static string GetSortingQuery(string sortValue)
        {
            switch (sortValue)
            {
                case "Стоимость ↑":
                    {
                        _sortingCommand = "order by Стоимость";
                    }
                    break;
                case "Стоимость ↓":
                    {
                        _sortingCommand = "order by Стоимость desc";
                    }
                    break;
            }

            return GetResultQuery();
        }

        private static string GetResultQuery()
        {
            if (_filterCommand.Length > 0 && _searchingCommand.Length > 0)
            {
                return $"{_baseQuery} where {_filterCommand} and {_searchingCommand} {_sortingCommand}";
            }

            if (_filterCommand.Length > 0)
            {
                return $"{_baseQuery} where {_filterCommand} {_sortingCommand}";
            }

            if (_searchingCommand.Length > 0)
            {
                return $"{_baseQuery} where {_searchingCommand} {_sortingCommand}";
            }

            return $"{_baseQuery} {_sortingCommand}";
        }

        public static string GetMakersQuery()
        {
            return "select distinct Производитель from products";
        }
    }
}
