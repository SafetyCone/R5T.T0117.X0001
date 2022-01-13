using System;
using System.IO;

using R5T.T0117;


namespace System
{
    public static class IFileGeneratorExtensions
    {
        public static void CreateProjectPlanFile(this IFileGenerator _,
            string projectPlanTextFilePath,
            string projectName,
            string projectDescription)
        {
            var lines = new[]
            {
                $"{projectName} - {projectDescription}",
                "",
                "GOALS:",
                "",
            };

            FileHelper.WriteAllLines(projectPlanTextFilePath, lines);
        }
    }
}
