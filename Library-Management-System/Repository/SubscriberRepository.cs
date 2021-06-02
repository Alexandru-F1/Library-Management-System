using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class SubscriberRepository : ISubscriberRepository
	{
		private readonly SubscriberContext subscriberContext;

		public SubscriberRepository(SubscriberContext subscriberContext)
		{
			this.subscriberContext = subscriberContext;
		}

		public void Add(Subscriber entity)
		{
			var response = subscriberContext.Add(entity);
			subscriberContext.SaveChanges();
		}

		public void Delete(int id)
		{
			subscriberContext.Remove(Find(id));
			subscriberContext.SaveChanges();
		}

		public Subscriber Find(int id)
		{
			return subscriberContext.Subscribers.Where(e => e.Id == id).FirstOrDefault();
		}

		public Subscriber FindByUsername(string username)
		{
			return subscriberContext.Subscribers.Where(e => e.UserName == username).FirstOrDefault();
		}

		public List<Subscriber> GetAll()
		{
			return subscriberContext.Subscribers.ToList();
		}

		public void Update(Subscriber entity)
		{
			var result = Find(entity.Id);
			result.UserName = entity.UserName;
			result.Password = entity.Password;
			result.Name = entity.Name;
			subscriberContext.SaveChanges();
		}
	}
}
