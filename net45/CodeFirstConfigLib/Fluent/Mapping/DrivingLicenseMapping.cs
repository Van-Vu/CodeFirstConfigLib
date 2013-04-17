using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class DrivingLicenseMapping: EntityTypeConfigurationBase<FluentDrivingLicense>
    {
        public DrivingLicenseMapping()
        {
            HasKey(x => x.UserId);
            HasRequired(x => x.User);

            ToTable("DrivingLicense");
        }
    }
}
