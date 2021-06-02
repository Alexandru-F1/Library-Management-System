using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public interface IRepository<E>
	{
		void Add(E entity);
		void Delete(int id);
		void Update(E entity);
		List<E> GetAll();
		E Find(int id);
	}
}
