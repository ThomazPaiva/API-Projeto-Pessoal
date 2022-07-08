using PequenosEncantos.Application.InputModel;
using PequenosEncantos.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PequenosEncantos.Application.Services.Interface
{
    public interface IJobsAlreadyMadeService
    {
        List<JobsAlreadyMadeViewModel> GetAllJobsAlreadyMade(string query);
        JobsAlreadyMadeDetailsViewModel GetJobsDetails(int id);
        int CreateANewJob(CreateANewJobInputModel createInputModel);
        void Update(UpdateJobInputModel updateInputModel);
        void ProjectStarted(int id);
        void ProjectFinished(int id);

    }
}
