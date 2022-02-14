using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoReInsert.Drives;

public class Drive
{
    public string Letter { get; private set; }
    public string Volume { get; private set; }

    public Drive(string letter, string volume)
    {
        Letter = letter;
        Volume = volume;
    }

    public DriveStatus GetStatus()
    {
        var drivesList = DriveInfo.GetDrives();
        foreach (var drive in drivesList)
        {
            if (drive.VolumeLabel == Volume)
            {
                if(drive.Name == Letter + @":\")
                    return DriveStatus.Correct;
                else
                    return DriveStatus.WrongDevice;
            }
        }

        return DriveStatus.NoDevice;
    }


}
