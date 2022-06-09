using kolokwium2.Dto;
using kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Services
{
    public class DbService : IDbService
    {
        private readonly MainDbContext _dbContext;

        public DbService(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<TrackDto>> getAlbumaAndSongsbyId(int id)
        {
            return await _dbContext.Tracks.Select(e => new TrackDto
            {
                Duration = e.Duration,
                IdTrack = e.IdTrack
            }).ToListAsync();
        }

        public async Task RemoveMusicianById(int musicianId) { 
              var musician = _dbContext.Musicans.Where(e => e.IdMusician == musicianId).FirstOrDefault();
           _dbContext.Remove(musician);
          await _dbContext.SaveChangesAsync();
        
            
        }
        // wyswietlenie wszystkich danych
        //public async Task<IEnumerable<PatientDto>> GetAllPatients()
        //{
        //    return await _dbContext.Patients.Select(e => new PatientDto
        //    {
        //        FirstName = e.FirstName,
        //        LastName = e.LastName,
        //        Birthdate = e.Birthdate,
        //    }).ToListAsync();
        //}
        //// insert entity
        //public async Task InsertDoctor(Doctor doctor)
        //{
        //    _dbContext.Doctors.Add(doctor);
        //   await _dbContext.SaveChangesAsync();
        //}

        //// usuwanie danych
        //public async Task RemoveDoctor(int idDoctor)
        //{
        //    var doctor = _dbContext.Doctors.Where(e => e.IdDoctor == idDoctor).FirstOrDefault();
        //    _dbContext.Remove(doctor);
        //    await _dbContext.SaveChangesAsync();
        //}

        // modyfikowanie danych 
        // public async update(// parametry)
        //        {
        //        var stud = new Student() { StudentId = 1, Name = "Bill" };

        //        stud.Name = "Steve"; 

        //using (var context = new SchoolContext())
        //{
        //    context.Update<Student>(stud);

        //    // or the followings are also valid
        //    // context.Students.Update(stud);
        //    // context.Attach<Student>(stud).State = EntityState.Modified;
        //    // context.Entry<Student>(stud).State = EntityState.Modified; 

        //    context.SaveChanges(); 
        //        }
    }
}
