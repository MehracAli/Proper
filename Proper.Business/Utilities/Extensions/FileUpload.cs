using Microsoft.AspNetCore.Http;

namespace Proper.Business.Utilities.Extensions
{
    public static class FileUpload
    {
        /// <summary>
        /// Bu metod, [Gərəkli patametrləri extension metoda göndərərək, faylın bu parametrlər vasitəsilə, metod daxilində yaradılan root-da saxlanmasını təmin edir və databazada saxlanacaq file adını da string olaraq geri qaytarır ].
        /// </summary>
        public static async Task<string> SaveFile(string webRoot,
                                                  IFormFile formFile,
                                                  params string[] folders)
        {
            string folderRoot = Path.Combine(folders);

            string fileName = Guid.NewGuid().ToString() + formFile.FileName;

            string fileRoot = Path.Combine(folderRoot, fileName);

            string mainRoot = Path.Combine(webRoot, fileRoot);

            using (FileStream fileStream = new(mainRoot, FileMode.Create))
            {
                await formFile.CopyToAsync(fileStream);
            }

            fileRoot = fileRoot.Replace("\\", "/");

            return fileRoot;
        }


        /// <summary>
        /// Bu metod, [IFormFile obyektərinin ölçü və tiplərini yoxlayır].
        /// </summary>
        public static bool CheckFile(this IFormFile formFile, int kb)
        {
            if (formFile.Length/1024 > kb)
            {
                return false;
            }
            else if (!formFile.ContentType.Contains("image/"))
            {
                return false;
            }

            return true;
        }
    }
}
