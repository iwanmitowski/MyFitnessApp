﻿namespace MyFitnessApp.Services.Data.Forum
{
    using System.Collections.Generic;

    using MyFitnessApp.Web.ViewModels.Forum;

    public interface IForumsService
    {
        IEnumerable<CategoryViewModel> GetAllCategories();
    }
}
