using SampleFileUpload.Models;

namespace SampleFileUpload.ViewModel
{

    //We are using View models so that we don't have to create migrations all the time
    public class FileUploadViewModel : FileCreation
    {
        public byte[] FileData { get; set; }

        public List<FileCreation> SystemFiles { get; set; }
    }
}
