﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace pbs_web_automation.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LoginWithIncorrectValues recording.
    /// </summary>
    [TestModule("0e5c833a-cf50-49f6-b84c-4f2804c24bc1", ModuleType.Recording, 1)]
    public partial class LoginWithIncorrectValues : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::pbs_web_automation.PBS_Repository repository.
        /// </summary>
        public static global::pbs_web_automation.PBS_Repository repo = global::pbs_web_automation.PBS_Repository.Instance;

        static LoginWithIncorrectValues instance = new LoginWithIncorrectValues();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LoginWithIncorrectValues()
        {
            varIncorrectPassword = "yourtext";
            varIncorrectUsername = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LoginWithIncorrectValues Instance
        {
            get { return instance; }
        }

#region Variables

        string _varIncorrectPassword;

        /// <summary>
        /// Gets or sets the value of variable varIncorrectPassword.
        /// </summary>
        [TestVariable("f6977274-57c1-4c01-93da-073eca8be32e")]
        public string varIncorrectPassword
        {
            get { return _varIncorrectPassword; }
            set { _varIncorrectPassword = value; }
        }

        string _varIncorrectUsername;

        /// <summary>
        /// Gets or sets the value of variable varIncorrectUsername.
        /// </summary>
        [TestVariable("0e58f968-d3db-45dd-8a8b-e105aad59e43")]
        public string varIncorrectUsername
        {
            get { return _varIncorrectUsername; }
            set { _varIncorrectUsername = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(0));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varIncorrectUsername' with focus on 'pbs_webSite.PartnerBereichPage.Benutzername'.", repo.pbs_webSite.PartnerBereichPage.BenutzernameInfo, new RecordItemIndex(1));
            repo.pbs_webSite.PartnerBereichPage.Benutzername.PressKeys(varIncorrectUsername);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varIncorrectPassword' with focus on 'pbs_webSite.PartnerBereichPage.Passwort'.", repo.pbs_webSite.PartnerBereichPage.PasswortInfo, new RecordItemIndex(2));
            repo.pbs_webSite.PartnerBereichPage.Passwort.PressKeys(varIncorrectPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'pbs_webSite.PartnerBereichPage.Anmelden' at Center.", repo.pbs_webSite.PartnerBereichPage.AnmeldenInfo, new RecordItemIndex(3));
            repo.pbs_webSite.PartnerBereichPage.Anmelden.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'pbs_webSite.PartnerBereichPage.Msg_AnErrorHasOccured'", repo.pbs_webSite.PartnerBereichPage.Msg_AnErrorHasOccuredInfo, new ActionTimeout(5000), new RecordItemIndex(4));
            repo.pbs_webSite.PartnerBereichPage.Msg_AnErrorHasOccuredInfo.WaitForExists(5000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
