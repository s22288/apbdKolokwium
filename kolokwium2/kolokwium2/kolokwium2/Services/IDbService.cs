using kolokwium2.Dto;
using kolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Services
{
    public interface IDbService 
    {
        // Task<IEnumerable<PatientDto>> GetAllPatients();
        //Task RemoveDoctor(int idDoctor);
        //Task InsertDoctor(Doctor doctor);
        Task<List<TrackDto>> getAlbumaAndSongsbyId(int id);

        Task RemoveMusicianById(int musicianId);
    }
}
