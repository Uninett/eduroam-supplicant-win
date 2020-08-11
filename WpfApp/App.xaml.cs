﻿using Newtonsoft.Json;
using SingleInstanceApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, ISingleInstance
    {
        private const string SingleInstanceUid = "7aab8621-df45-4eb5-85c3-c70c06e8a22e";

        public bool StartHiddenInTray { get; private set; } = false;

        [STAThread]
        public static void Main(string[] args)
        {
            if (SingleInstance<App>.InitializeAsFirstInstance(SingleInstanceUid))
            {
                // making it this far means that we are THE single instance
                try
                {
                    if (PreGuiCommandLineArgs(args))
                        return;
                    var app = new App();
                    app.InitializeComponent();
                    app.Run();
                }
                finally
                {
                    SingleInstance<App>.Cleanup();
                }
            }
        }

        /// <summary>
        /// Handles command line args not related to wpf behaviour
        /// </summary>
        /// <returns>true if startup is to be aborted</returns>
        static bool PreGuiCommandLineArgs(string[] args)
        {
            // shorthand
            bool contains(string check) =>
                args.Any(param => string.Equals(param, check, StringComparison.InvariantCultureIgnoreCase));

            if (contains("/install")) // todo: dialog stuff
                Installer.EnsureIsInstalled();
            else if (contains("/uninstall")) // todo: prompt user for confirmation
                Installer.ExitAndUninstallSelf();
            else
                return false;
            return contains("/close");
        }

        /// <summary>
        /// WPF startup handler, first instance runs this.
        /// Handles command line args related to wpf behaviour
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            // shorthand
            bool contains(string check) =>
                e == null ? false :
                e.Args.Any(param => string.Equals(param, check, StringComparison.InvariantCultureIgnoreCase));

            if (contains("/background")) // TODO && Installer.IsRunningFromInstallLocation)
            {
                Debug.WriteLine("Starting hidden in tray");
                StartHiddenInTray = true;
            }

            base.OnStartup(e);
        }

        /// <summary>
        /// Signal handler from secondary instances.
        /// Handles command line arguments sent from second instance.
        /// </summary>
        public bool SignalExternalCommandLineArgs(IList<string> args)
        {
            // shorthand
            bool contains(string check) =>
                args.Skip(1).Any(param => string.Equals(param, check, StringComparison.InvariantCultureIgnoreCase));

            Debug.WriteLine("Got external cli args: {0} from {1}",
                JsonConvert.SerializeObject(args.Skip(1).ToList()), args.FirstOrDefault());

            if (contains("/close"))
                Shutdown();

            // Return value has no effect:
            // https://github.com/taylorjonl/SingleInstanceApp/blob/master/SingleInstance.cs#L261
            return true;
        }


        private static AssemblyName AssemblyName
        { get => Assembly.GetExecutingAssembly().GetName(); }

        // TODO: can we populate with from AssemblyName?
        public static readonly SelfInstaller Installer = new SelfInstaller(
            applicationIdentifier: "geteduroam",
            applicationMetadata: new SelfInstaller.ApplicationMeta()
            {
                DisplayName = "geteduroam",  // [REQUIRED] ProductName
                Publisher = "Uninett",  // [REQUIRED] Manufacturer
                Version = AssemblyName.Version.ToString(),
                VersionMajor = AssemblyName.Version.Major.ToString(CultureInfo.InvariantCulture),
                VersionMinor = AssemblyName.Version.Minor.ToString(CultureInfo.InvariantCulture),
                HelpLink = null,  // ARPHELPLINK
                HelpTelephone = null,  // ARPHELPTELEPHONE
                InstallSource = null,  // SourceDir
                URLInfoAbout = null,  // ARPURLINFOABOUT
                URLUpdateInfo = null,  // ARPURLUPDATEINFO
                AuthorizedCDFPrefix = null,  // ARPAUTHORIZEDCDFPREFIX
                Comments = null,  // [NICE TO HAVE] ARPCOMMENTS. Comments provided to the Add or Remove Programs control panel.
                Contact = null,  // [NICE TO HAVE] ARPCONTACT. Contact provided to the Add or Remove Programs control panel.
                Language = null,  // ProductLanguage
                Readme = null,  // [NICE TO HAVE] ARPREADME. Readme provided to the Add or Remove Programs control panel.
                SettingsIdentifier = null,  // MSIARPSETTINGSIDENTIFIER. contains a semi-colon delimited list of the registry locations where the application stores a user's settings and preferences.
                NoRepair = true,
                NoModify = true,
            }
        );

    }
}
