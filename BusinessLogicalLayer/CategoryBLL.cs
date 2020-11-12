using BusinessLogicalLayer.Checkers;
using Common;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    class CategoryBLL : BaseValidator<Category>
    {
        private CategoryDAO categoryDAO = new CategoryDAO();
        public Response Insert(Category item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                response = categoryDAO.IsCategoryByNameUnique(item.Nome);
                if (response.Success)
                {
                    return categoryDAO.Insert(item);
                }
            }
            return response;
        }
        public QueryResponse<Category> GetAll()
        {
            return categoryDAO.GetAll();
        }
        public override Response Validate(Category item)
        {
            if (CheckAnyProperty.IsAnyNullOrEmpty(item))
            {
                AddError("Todos os campos devem ser informados");
                return base.Validate(item);
            }
            foreach (string err in CheckAttributeLength.AttributeLength<Category>(item))
            {
                AddError(err);
            }
            return base.Validate(item);
        }
    }
}
