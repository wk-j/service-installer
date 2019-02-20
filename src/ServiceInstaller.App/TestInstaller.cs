using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;

namespace ServiceInstaller.App {
    [RunInstaller(true)]
    public class TestInstaller : Installer {
        public override void Install(IDictionary stateSaver) {
            base.Install(stateSaver);
            File.Create("test");
        }

        public override void Uninstall(IDictionary savedState) {
            File.Delete("test");
            base.Uninstall(savedState);
        }
    }
}
