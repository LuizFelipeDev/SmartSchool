using SmartSchool.API.Helpers;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();


        //Alunos
        Task<PageList<Aluno>> GetAllAlunosAsync(PageParams pageParams, bool includeProfessor = false);
        Aluno[] GetAllAlunos(bool includeProfessor = false);
        Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);
        Aluno GetAlunoById(int alunoId, bool includeProfessor = false);
        Task<Aluno[]> GetAllAlunosByDisciplinaIdAsync(int disciplinaId, bool includeProfessor = false);


        //Professores
        Professor[] GetAllProfessores(bool includeAluno = false);
        Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAluno = false);
        Professor GetProfessorById(int professorId, bool includeAluno = false);
        Professor[] GetProfessoresByAlunoId(int alunoId, bool includeAluno = false);
    }
}
