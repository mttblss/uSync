using System.Collections.Generic;

namespace uSync.BackOffice.Models;

/// <summary>
///  results of a file upload and validate
/// </summary>
public class UploadImportResult
{
    /// <summary>
    ///  upload was successful.
    /// </summary>
    public required bool Success { get; set; }

    /// <summary>
    ///  list of possible errors (if upload failed)
    /// </summary>
    public IEnumerable<string> Errors { get; set; } = [];
}
