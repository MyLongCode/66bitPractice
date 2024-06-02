using Dal.EF;
using Dal.Footballer.Interfaces;
using Dal.Footballer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Footballer
{
    public class FootballerRepository : IFootballerRepository
    {
        private ApplicationDbContext db;
        public FootballerRepository(ApplicationDbContext context) => this.db = context;
        public int CreateFootballer(FootballerDal footballer)
        {
            db.Footballers.Add(footballer);
            db.SaveChanges();
            return footballer.Id;
        }

        public int DeleteFootballerById(int id)
        {
            var footballer = db.Footballers.Find(id);
            if (footballer == null) return -1;
            db.Footballers.Remove(footballer);
            db.SaveChanges();
            return id;
        }

        public IEnumerable<FootballerDal> GetAllFootballers()
        {
            return db.Footballers.Include(f => f.Team).ToList();
        }

        public IEnumerable<FootballerDal> GetAllFootballersByTeamId(int teamId)
        {
            return db.Footballers.Where(f => f.TeamId == teamId).ToList();
        }

        public FootballerDal GetFootballerById(int id)
        {
            var footballer = db.Footballers.Include(f => f.Team).FirstOrDefault(f => f.Id == id);
            return footballer;
        }

        public int UpdateFootballer(FootballerDal footballer)
        {
            //var _footballer = db.Footballers.FirstOrDefault(p => p.Id == footballer.Id);
            //if (_footballer != null)
            //{
            //    _footballer.BirthdayDate = footballer.BirthdayDate;
            //    _footballer.TeamId = footballer.TeamId;
            //    _footballer.Country = footballer.Country;
            //    _footballer.FirstName = footballer.FirstName;
            //    _footballer.LastName = footballer.LastName;
            //    _footballer.Sex = footballer.Sex;
            //    db.SaveChanges();
            //}

            db.Update(footballer);
            db.Update(footballer.Team);
            db.SaveChanges();
            
            return footballer.Id;
        }
    }
}
