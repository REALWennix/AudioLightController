using System;
using System.Drawing;
using System.Windows.Forms;
using LightController.Settings;

namespace LightController.Forms
{
    public partial class AboutForm : Form
    {
        private MainForm mainForm;

        public AboutForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // Load application information from SettingsClass
            labelAppName.Text = "LightController";
            labelVersion.Text = "Version: " + Application.ProductVersion;
            labelAuthor.Text = "Author: Martin Rosič & Vašek Calda";

            // Load EULA content into WebBrowser
            string eulaHtml = "<h2>End-User License Agreement (EULA) of <span class=app_name>LightController</span></h2><p>This End-User License Agreement (\"EULA\") is a legal agreement between you and <span class=company_name>Martin Rosič</span>.<p>This EULA agreement governs your acquisition and use of our <span class=app_name>LightController</span> software (\"Software\") directly from <span class=company_name>Martin Rosič</span> or indirectly through a <span class=company_name>Martin Rosič</span> authorized reseller or distributor (a \"Reseller\").<p>Please read this EULA agreement carefully before completing the installation process and using the <span class=app_name>LightController</span> software. It provides a license to use the <span class=app_name>LightController</span> software and contains warranty information and liability disclaimers.<p>If you register for a free trial of the <span class=app_name>LightController</span> software, this EULA agreement will also govern that trial. By clicking \"accept\" or installing and/or using the <span class=app_name>LightController</span> software, you are confirming your acceptance of the Software and agreeing to become bound by the terms of this EULA agreement.<p>If you are entering into this EULA agreement on behalf of a company or other legal entity, you represent that you have the authority to bind such entity and its affiliates to these terms and conditions. If you do not have such authority or if you do not agree with the terms and conditions of this EULA agreement, do not install or use the Software, and you must not accept this EULA agreement.<p>This EULA agreement shall apply only to the Software supplied by <span class=company_name>Martin Rosič</span> herewith regardless of whether other software is referred to or described herein. The terms also apply to any <span class=company_name>Martin Rosič</span> updates, supplements, Internet-based services, and support services for the Software, unless other terms accompany those items on delivery. If so, those terms apply.<h3>License Grant</h3><p><span class=company_name>Martin Rosič</span> hereby grants you a personal, non-transferable, non-exclusive licence to use the <span class=app_name>LightController</span> software on your devices in accordance with the terms of this EULA agreement.<p>You are permitted to load the <span class=app_name>LightController</span> software (for example a PC, laptop, mobile or tablet) under your control. You are responsible for ensuring your device meets the minimum requirements of the <span class=app_name>LightController</span> software.<p>You are not permitted to:<ul><li>Edit, alter, modify, adapt, translate or otherwise change the whole or any part of the Software nor permit the whole or any part of the Software to be combined with or become incorporated in any other software, nor decompile, disassemble or reverse engineer the Software or attempt to do any such things<li>Reproduce, copy, distribute, resell or otherwise use the Software for any commercial purpose<li>Allow any third party to use the Software on behalf of or for the benefit of any third party<li>Use the Software in any way which breaches any applicable local, national or international law<li>use the Software for any purpose that <span class=company_name>Martin Rosič</span> considers is a breach of this EULA agreement</ul><h3>Intellectual Property and Ownership</h3><p><span class=company_name>Martin Rosič</span> shall at all times retain ownership of the Software as originally downloaded by you and all subsequent downloads of the Software by you. The Software (and the copyright, and other intellectual property rights of whatever nature in the Software, including any modifications made thereto) are and shall remain the property of <span class=company_name>Martin Rosič</span>.<p><span class=company_name>Martin Rosič</span> reserves the right to grant licences to use the Software to third parties.<h3>Termination</h3><p>This EULA agreement is effective from the date you first use the Software and shall continue until terminated. You may terminate it at any time upon written notice to <span class=company_name>Martin Rosič</span>.<p>It will also terminate immediately if you fail to comply with any term of this EULA agreement. Upon such termination, the licenses granted by this EULA agreement will immediately terminate and you agree to stop all access and use of the Software. The provisions that by their nature continue and survive will survive any termination of this EULA agreement.<h3>Governing Law</h3><p>This EULA agreement, and any dispute arising out of or in connection with this EULA agreement, shall be governed by and construed in accordance with the laws of <span class=country>cz</span>.";
            webBrowser_EULA.DocumentText = eulaHtml;

            AddHardwareSpecsPanel();
        }

        private void AddHardwareSpecsPanel()
        {
            // Load minimum and recommended hardware specs from SettingsClass
            string minSpecs = "Minimum Requirements:\r\n" +
                             "- Processor: " + SettingsClass.Instance.MinProcessor + "\r\n" +
                             "- RAM: " + SettingsClass.Instance.MinRAM + "\r\n" +
                             "- Graphics Card: " + SettingsClass.Instance.MinGraphicsCard + "\r\n";

            string recommendedSpecs = "Recommended Requirements:\r\n" +
                                      "- Processor: " + SettingsClass.Instance.RecommendedProcessor + "\r\n" +
                                      "- RAM: " + SettingsClass.Instance.RecommendedRAM + "\r\n" +
                                      "- Graphics Card: " + SettingsClass.Instance.RecommendedGraphicsCard + "\r\n";


            lbl_MinSpecs.Text = "Minimum Requirements:";
            lbl_MinSpecs.ForeColor = Color.DarkBlue;
            lbl_MinSpecs.Dock = DockStyle.Top;
            panel_min_specs.Controls.Add(lbl_MinSpecs);
            txboxMinSpecs.Text = minSpecs;

            txboxRecSpecs.Text = recommendedSpecs;
            lbl_RecSpecs.Text = "Recommended Requirements:";
            lbl_RecSpecs.ForeColor = Color.DarkBlue;
            lbl_RecSpecs.Dock = DockStyle.Top;
            panel_rec_specs.Controls.Add(lbl_RecSpecs);
        }
    }
}
