﻿using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
  public interface ILanguageRepository : IEntityRepository<Language>
  {
    Task<List<SelectionItem>> GetLanguagesLookUp();
    Task<List<SelectionItem>> GetLanguagesLookUpWithCode();
  }
}