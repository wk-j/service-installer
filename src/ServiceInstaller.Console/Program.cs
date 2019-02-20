using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Reflection;
using Terminal = System.Console;

namespace ServiceInstaller.Console {

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

    class Program {
        static void Main(string[] args) {
            var assembly = args[0];
            try {
                ManagedInstallerClass.InstallHelper(new string[] {
                    "-ShowCallStack",
                    "-Uninstall",
                    "-LogToConsole=true",
                    assembly
                });
                ManagedInstallerClass.InstallHelper(new string[] {
                    "-ShowCallStack",
                    "-LogToConsole=true",
                    assembly
                });
            } catch (Exception ex) {
                Terminal.WriteLine(ex.ToString());
            }
        }
    }
}
