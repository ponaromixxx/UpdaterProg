using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Resources;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;


namespace TestApp.Properties {
    [GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [DebuggerNonUserCodeAttribute()]
    [CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }

        [EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("TestApp.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        [EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        internal static string en_about_author_label {
            get {
                return ResourceManager.GetString("en_about_author_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на E-Mail.
        /// </summary>
        internal static string en_about_email_label {
            get {
                return ResourceManager.GetString("en_about_email_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TestApp converts a TXT file to a EPUB file.{0}{0}If you have any suggestions, please feel free to email me.{0}{0}Thank you for your support! :).
        /// </summary>
        internal static string en_about_intro {
            get {
                return ResourceManager.GetString("en_about_intro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Intro.
        /// </summary>
        internal static string en_about_intro_label {
            get {
                return ResourceManager.GetString("en_about_intro_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Version.
        /// </summary>
        internal static string en_about_version_label {
            get {
                return ResourceManager.GetString("en_about_version_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Enable AOT.
        /// </summary>
        internal static string en_AOT {
            get {
                return ResourceManager.GetString("en_AOT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Disable AOT.
        /// </summary>
        internal static string en_AOT_cancel {
            get {
                return ResourceManager.GetString("en_AOT_cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TestApp.
        /// </summary>
        internal static string en_app_name {
            get {
                return ResourceManager.GetString("en_app_name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Update failed!&lt;br/&gt;Please try again later!.
        /// </summary>
        internal static string en_autoUpdater_msg_failed {
            get {
                return ResourceManager.GetString("en_autoUpdater_msg_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Failed.
        /// </summary>
        internal static string en_autoUpdater_msg_failed_title {
            get {
                return ResourceManager.GetString("en_autoUpdater_msg_failed_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Success!&lt;br/&gt;Application restarts in 5 seconds!.
        /// </summary>
        internal static string en_autoUpdater_msg_success {
            get {
                return ResourceManager.GetString("en_autoUpdater_msg_success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Success.
        /// </summary>
        internal static string en_autoUpdater_msg_success_title {
            get {
                return ResourceManager.GetString("en_autoUpdater_msg_success_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Update terminated!&lt;br/&gt;Cannot complete update!.
        /// </summary>
        internal static string en_autoUpdater_msg_terminated {
            get {
                return ResourceManager.GetString("en_autoUpdater_msg_terminated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Terminated.
        /// </summary>
        internal static string en_autoUpdater_msg_terminated_title {
            get {
                return ResourceManager.GetString("en_autoUpdater_msg_terminated_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Latest version already!.
        /// </summary>
        internal static string en_autoUpdater_result_latest {
            get {
                return ResourceManager.GetString("en_autoUpdater_result_latest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на No update info found!.
        /// </summary>
        internal static string en_autoUpdater_result_none {
            get {
                return ResourceManager.GetString("en_autoUpdater_result_none", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Always-on-Top Enabled.
        /// </summary>
        internal static string en_balloontip_AOT {
            get {
                return ResourceManager.GetString("en_balloontip_AOT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Always-on-Top Disabled.
        /// </summary>
        internal static string en_balloontip_AOT_cancel {
            get {
                return ResourceManager.GetString("en_balloontip_AOT_cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Failed!.
        /// </summary>
        internal static string en_balloontip_fail {
            get {
                return ResourceManager.GetString("en_balloontip_fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на No title or author info found in the file name!.
        /// </summary>
        internal static string en_balloontip_NoEnTitleAuthor {
            get {
                return ResourceManager.GetString("en_balloontip_NoEnTitleAuthor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на File name example: &quot;BookName By Author&quot;{0}(The word &quot;by&quot; must present, case-insensitive){0}{0}Will use file name as book name, &quot;TestApp&quot; as author name..
        /// </summary>
        internal static string en_balloontip_NoEnTitleAuthor_detail {
            get {
                return ResourceManager.GetString("en_balloontip_NoEnTitleAuthor_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error.
        /// </summary>
        internal static string en_balloontip_NoHelpFile {
            get {
                return ResourceManager.GetString("en_balloontip_NoHelpFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на No help file found!.
        /// </summary>
        internal static string en_balloontip_NoHelpFile_detail {
            get {
                return ResourceManager.GetString("en_balloontip_NoHelpFile_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error.
        /// </summary>
        internal static string en_balloontip_NoKindleGen {
            get {
                return ResourceManager.GetString("en_balloontip_NoKindleGen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на No KindleGen.exe found!.
        /// </summary>
        internal static string en_balloontip_NoKindleGen_detail {
            get {
                return ResourceManager.GetString("en_balloontip_NoKindleGen_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на No title or author info found in the file name!.
        /// </summary>
        internal static string en_balloontip_NoZhTitleAuthor {
            get {
                return ResourceManager.GetString("en_balloontip_NoZhTitleAuthor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на File name example: &quot;《书名》作者：作者名&quot;{0}(The word &quot;作者&quot; must present; 《》can be omitted.){0}{0}Will use file name as book name, &quot;TestApp&quot; as author name..
        /// </summary>
        internal static string en_balloontip_NoZhTitleAuthor_detail {
            get {
                return ResourceManager.GetString("en_balloontip_NoZhTitleAuthor_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Created!.
        /// </summary>
        internal static string en_balloontip_success {
            get {
                return ResourceManager.GetString("en_balloontip_success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Reminder.
        /// </summary>
        internal static string en_balloontip_title {
            get {
                return ResourceManager.GetString("en_balloontip_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TOC Extraction Done!.
        /// </summary>
        internal static string en_balloontip_TOC_done {
            get {
                return ResourceManager.GetString("en_balloontip_TOC_done", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cancel.
        /// </summary>
        internal static string en_button_cancel {
            get {
                return ResourceManager.GetString("en_button_cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на OK.
        /// </summary>
        internal static string en_button_ok {
            get {
                return ResourceManager.GetString("en_button_ok", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Show/Hide .
        /// </summary>
        internal static string en_contextual_menu_1 {
            get {
                return ResourceManager.GetString("en_contextual_menu_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Exit.
        /// </summary>
        internal static string en_contextual_menu_2 {
            get {
                return ResourceManager.GetString("en_contextual_menu_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Failed to load settings file. Going to import defaul settings!.
        /// </summary>
        internal static string en_event_setting_load_error {
            get {
                return ResourceManager.GetString("en_event_setting_load_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Are you sure to reset all settings?.
        /// </summary>
        internal static string en_event_setting_reset {
            get {
                return ResourceManager.GetString("en_event_setting_reset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Confirmation.
        /// </summary>
        internal static string en_event_setting_reset_title {
            get {
                return ResourceManager.GetString("en_event_setting_reset_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;font size=&quot;10&quot;&gt;&lt;b&gt;    ABOUT    &lt;/b&gt;&lt;/font&gt;.
        /// </summary>
        internal static string en_mainpage_about {
            get {
                return ResourceManager.GetString("en_mainpage_about", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Enable AOT.
        /// </summary>
        internal static string en_mainpage_rm_item1 {
            get {
                return ResourceManager.GetString("en_mainpage_rm_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Minimize.
        /// </summary>
        internal static string en_mainpage_rm_item2 {
            get {
                return ResourceManager.GetString("en_mainpage_rm_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Close.
        /// </summary>
        internal static string en_mainpage_rm_item3 {
            get {
                return ResourceManager.GetString("en_mainpage_rm_item3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;font size=&quot;10&quot;&gt;&lt;b&gt;    SETTINGS    &lt;/b&gt;&lt;/font&gt;.
        /// </summary>
        internal static string en_mainpage_settings {
            get {
                return ResourceManager.GetString("en_mainpage_settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;Author&lt;/b&gt;.
        /// </summary>
        internal static string en_mainpage1_cover_author_label {
            get {
                return ResourceManager.GetString("en_mainpage1_cover_author_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;Title&lt;/b&gt;.
        /// </summary>
        internal static string en_mainpage1_cover_bookname_label {
            get {
                return ResourceManager.GetString("en_mainpage1_cover_bookname_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;Description&lt;/b&gt;.
        /// </summary>
        internal static string en_mainpage1_cover_intro_label {
            get {
                return ResourceManager.GetString("en_mainpage1_cover_intro_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Drag a TXT file here.
        /// </summary>
        internal static string en_mainpage1_img1_string1 {
            get {
                return ResourceManager.GetString("en_mainpage1_img1_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на OR... Double click here.
        /// </summary>
        internal static string en_mainpage1_img1_string2 {
            get {
                return ResourceManager.GetString("en_mainpage1_img1_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Processing TXT.
        /// </summary>
        internal static string en_mainpage1_img2_string1 {
            get {
                return ResourceManager.GetString("en_mainpage1_img2_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Please wait....
        /// </summary>
        internal static string en_mainpage1_img2_string2 {
            get {
                return ResourceManager.GetString("en_mainpage1_img2_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TXT selected!.
        /// </summary>
        internal static string en_mainpage1_img3_string1 {
            get {
                return ResourceManager.GetString("en_mainpage1_img3_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Text Files.
        /// </summary>
        internal static string en_mainpage1_txt_click_filter {
            get {
                return ResourceManager.GetString("en_mainpage1_txt_click_filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Please select a TXT file.
        /// </summary>
        internal static string en_mainpage1_txt_click_title {
            get {
                return ResourceManager.GetString("en_mainpage1_txt_click_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на One file at a time please!.
        /// </summary>
        internal static string en_mainpage1_txt_dragdrop_singlefile {
            get {
                return ResourceManager.GetString("en_mainpage1_txt_dragdrop_singlefile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TXT file only!.
        /// </summary>
        internal static string en_mainpage1_txt_dragdrop_txtonly {
            get {
                return ResourceManager.GetString("en_mainpage1_txt_dragdrop_txtonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Image file only!.
        /// </summary>
        internal static string en_mainpage2_cover_dragdrop_imgonly {
            get {
                return ResourceManager.GetString("en_mainpage2_cover_dragdrop_imgonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на One file at a time please!.
        /// </summary>
        internal static string en_mainpage2_cover_dragdrop_singlefile {
            get {
                return ResourceManager.GetString("en_mainpage2_cover_dragdrop_singlefile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Previous cover picture deletion failed!.
        /// </summary>
        internal static string en_mainpage2_helper_cover_delete_failed {
            get {
                return ResourceManager.GetString("en_mainpage2_helper_cover_delete_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Image quality must be between 0 and 100!.
        /// </summary>
        internal static string en_mainpage2_helper_img_quality {
            get {
                return ResourceManager.GetString("en_mainpage2_helper_img_quality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Note picture deletion failed!.
        /// </summary>
        internal static string en_mainpage2_helper_notepic_delete_failed {
            get {
                return ResourceManager.GetString("en_mainpage2_helper_notepic_delete_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Book Cover.
        /// </summary>
        internal static string en_mainpage2_img_string {
            get {
                return ResourceManager.GetString("en_mainpage2_img_string", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Invalid action!.
        /// </summary>
        internal static string en_mainpage2_invalid_action {
            get {
                return ResourceManager.GetString("en_mainpage2_invalid_action", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Export TOC.
        /// </summary>
        internal static string en_mainpage2_rm1_item1 {
            get {
                return ResourceManager.GetString("en_mainpage2_rm1_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Clear TOC.
        /// </summary>
        internal static string en_mainpage2_rm1_item2 {
            get {
                return ResourceManager.GetString("en_mainpage2_rm1_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Import TOC.
        /// </summary>
        internal static string en_mainpage2_rm1_item3 {
            get {
                return ResourceManager.GetString("en_mainpage2_rm1_item3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Chapters UP.
        /// </summary>
        internal static string en_mainpage2_rm2_item1 {
            get {
                return ResourceManager.GetString("en_mainpage2_rm2_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Chapters DOWN.
        /// </summary>
        internal static string en_mainpage2_rm2_item2 {
            get {
                return ResourceManager.GetString("en_mainpage2_rm2_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Use generated cover.
        /// </summary>
        internal static string en_mainpage2_rm3_item1 {
            get {
                return ResourceManager.GetString("en_mainpage2_rm3_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Choose a cover.
        /// </summary>
        internal static string en_mainpage2_rm3_item2 {
            get {
                return ResourceManager.GetString("en_mainpage2_rm3_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Image Files.
        /// </summary>
        internal static string en_mainpage2_select_cover_filter {
            get {
                return ResourceManager.GetString("en_mainpage2_select_cover_filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Please select a cover picture.
        /// </summary>
        internal static string en_mainpage2_select_cover_title {
            get {
                return ResourceManager.GetString("en_mainpage2_select_cover_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Clear TOC.
        /// </summary>
        internal static string en_mainpage2_TOC_clear {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_clear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на It&apos;s recommended to save the current TOC first{0}Are you sure to clear the current TOC?.
        /// </summary>
        internal static string en_mainpage2_TOC_clear_confirm_detail {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_clear_confirm_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Confirmation.
        /// </summary>
        internal static string en_mainpage2_TOC_clear_confirm_title {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_clear_confirm_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TOC is already empty. Can&apos;t be cleared again!.
        /// </summary>
        internal static string en_mainpage2_TOC_clear_invalid {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_clear_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TOC cleared!.
        /// </summary>
        internal static string en_mainpage2_TOC_cleared {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_cleared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на One file at a time please!.
        /// </summary>
        internal static string en_mainpage2_TOC_dragdrop_singlefile {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_dragdrop_singlefile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TXT file only!.
        /// </summary>
        internal static string en_mainpage2_TOC_dragdrop_txtonly {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_dragdrop_txtonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Export TOC.
        /// </summary>
        internal static string en_mainpage2_TOC_export {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_export", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TOC is already empty. Can&apos;t be exported!.
        /// </summary>
        internal static string en_mainpage2_TOC_export_invalid {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_export_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TOC exported to: .
        /// </summary>
        internal static string en_mainpage2_TOC_exported {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_exported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Import TOC.
        /// </summary>
        internal static string en_mainpage2_TOC_import {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_import", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Text Files.
        /// </summary>
        internal static string en_mainpage2_TOC_import_click_filter {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_import_click_filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Please select a TOC file.
        /// </summary>
        internal static string en_mainpage2_TOC_import_click_title {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_import_click_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Invalid TOC file!.
        /// </summary>
        internal static string en_mainpage2_TOC_import_invalid {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_import_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TOC imported!.
        /// </summary>
        internal static string en_mainpage2_TOC_imported {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_imported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Chapter Title.
        /// </summary>
        internal static string en_mainpage2_TOC_list_ChapterTitle {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_list_ChapterTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Line Number.
        /// </summary>
        internal static string en_mainpage2_TOC_list_LineNumber {
            get {
                return ResourceManager.GetString("en_mainpage2_TOC_list_LineNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Author.
        /// </summary>
        internal static string en_mainpage3_bookauthor_label {
            get {
                return ResourceManager.GetString("en_mainpage3_bookauthor_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Description.
        /// </summary>
        internal static string en_mainpage3_bookintro_label {
            get {
                return ResourceManager.GetString("en_mainpage3_bookintro_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Title.
        /// </summary>
        internal static string en_mainpage3_bookname_label {
            get {
                return ResourceManager.GetString("en_mainpage3_bookname_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Word Count.
        /// </summary>
        internal static string en_mainpage3_bookwordcount_label {
            get {
                return ResourceManager.GetString("en_mainpage3_bookwordcount_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Unique Word Count.
        /// </summary>
        internal static string en_mainpage3_bookwordcountnr_label {
            get {
                return ResourceManager.GetString("en_mainpage3_bookwordcountnr_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Can&apos;t find .
        /// </summary>
        internal static string en_mainpage3_copyImageFile_string1 {
            get {
                return ResourceManager.GetString("en_mainpage3_copyImageFile_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0}Process stopped!.
        /// </summary>
        internal static string en_mainpage3_copyImageFile_string2 {
            get {
                return ResourceManager.GetString("en_mainpage3_copyImageFile_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Selected body font is not a TTF font. Can&apos;t be embedded!.
        /// </summary>
        internal static string en_mainpage3_generateEpub_body_not_ttf {
            get {
                return ResourceManager.GetString("en_mainpage3_generateEpub_body_not_ttf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на No source TXT file! Please select a TXT file and retry!.
        /// </summary>
        internal static string en_mainpage3_generateEpub_no_file {
            get {
                return ResourceManager.GetString("en_mainpage3_generateEpub_no_file", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Selected title font is not a TTF font. Can&apos;t be embedded!.
        /// </summary>
        internal static string en_mainpage3_generateEpub_title_not_ttf {
            get {
                return ResourceManager.GetString("en_mainpage3_generateEpub_title_not_ttf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Don&apos;t need to embed title font!.
        /// </summary>
        internal static string en_mainpage3_helper_fontsubset_string1 {
            get {
                return ResourceManager.GetString("en_mainpage3_helper_fontsubset_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Don&apos;t need to embed body font!.
        /// </summary>
        internal static string en_mainpage3_helper_fontsubset_string2 {
            get {
                return ResourceManager.GetString("en_mainpage3_helper_fontsubset_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Going to use full set font instead!.
        /// </summary>
        internal static string en_mainpage3_helper_fontsubset_string3 {
            get {
                return ResourceManager.GetString("en_mainpage3_helper_fontsubset_string3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Invalid TOC! Line number can only be numbers{0}Cannot continue creating EPUB!.
        /// </summary>
        internal static string en_mainpage3_helper_TOC_invalid {
            get {
                return ResourceManager.GetString("en_mainpage3_helper_TOC_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;File: &lt;/b&gt;.
        /// </summary>
        internal static string en_mainpage3_location_label {
            get {
                return ResourceManager.GetString("en_mainpage3_location_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ➢  Next Book  ➣.
        /// </summary>
        internal static string en_mainpage3_newbook_button {
            get {
                return ResourceManager.GetString("en_mainpage3_newbook_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Creating EPUB....
        /// </summary>
        internal static string en_mainpage3_processing_label1 {
            get {
                return ResourceManager.GetString("en_mainpage3_processing_label1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на EPUB Created!.
        /// </summary>
        internal static string en_mainpage3_processing_label2 {
            get {
                return ResourceManager.GetString("en_mainpage3_processing_label2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Failed!!.
        /// </summary>
        internal static string en_mainpage3_processing_label3 {
            get {
                return ResourceManager.GetString("en_mainpage3_processing_label3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Apply Settings.
        /// </summary>
        internal static string en_mainpage3_stepItem1_string1 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem1_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Apply font and&lt;br/&gt;paragraph settings.
        /// </summary>
        internal static string en_mainpage3_stepItem1_string2 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem1_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на HTML.
        /// </summary>
        internal static string en_mainpage3_stepItem2_string1 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem2_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Extract chapters&lt;br/&gt;Create HTMLs.
        /// </summary>
        internal static string en_mainpage3_stepItem2_string2 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem2_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Font.
        /// </summary>
        internal static string en_mainpage3_stepItem3_string1 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem3_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Extract words&lt;br/&gt;Create fonts.
        /// </summary>
        internal static string en_mainpage3_stepItem3_string2 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem3_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Misc Files.
        /// </summary>
        internal static string en_mainpage3_stepItem4_string1 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem4_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Create CSS, OPF,&lt;br/&gt;NCX, MIMETYPE etc..
        /// </summary>
        internal static string en_mainpage3_stepItem4_string2 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem4_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на EPUB.
        /// </summary>
        internal static string en_mainpage3_stepItem5_string1 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem5_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Pack all files&lt;br/&gt;with EPUB rules.
        /// </summary>
        internal static string en_mainpage3_stepItem5_string2 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem5_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на MOBI.
        /// </summary>
        internal static string en_mainpage3_stepItem6_string1 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem6_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Create MOBI&lt;br/&gt;based on EPUB.
        /// </summary>
        internal static string en_mainpage3_stepItem6_string2 {
            get {
                return ResourceManager.GetString("en_mainpage3_stepItem6_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;Time: &lt;/b&gt;.
        /// </summary>
        internal static string en_mainpage3_time_label1 {
            get {
                return ResourceManager.GetString("en_mainpage3_time_label1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на sec.
        /// </summary>
        internal static string en_mainpage3_time_label2 {
            get {
                return ResourceManager.GetString("en_mainpage3_time_label2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на EPUB Settings.
        /// </summary>
        internal static string en_settings_item1 {
            get {
                return ResourceManager.GetString("en_settings_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Page Settings.
        /// </summary>
        internal static string en_settings_item2 {
            get {
                return ResourceManager.GetString("en_settings_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Content Settings.
        /// </summary>
        internal static string en_settings_item3 {
            get {
                return ResourceManager.GetString("en_settings_item3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на App Settings.
        /// </summary>
        internal static string en_settings_item4 {
            get {
                return ResourceManager.GetString("en_settings_item4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на %.
        /// </summary>
        internal static string en_settings_label_percentage {
            get {
                return ResourceManager.GetString("en_settings_label_percentage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ⤒⤒          Save     Settings          ⤒⤒.
        /// </summary>
        internal static string en_settings_settings_done_button {
            get {
                return ResourceManager.GetString("en_settings_settings_done_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Settings Saved!.
        /// </summary>
        internal static string en_settings_settings_success {
            get {
                return ResourceManager.GetString("en_settings_settings_success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cover becomes the first page.
        /// </summary>
        internal static string en_settings1_3_coverfirstpage_label {
            get {
                return ResourceManager.GetString("en_settings1_3_coverfirstpage_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cover does NOT show up in TOC.
        /// </summary>
        internal static string en_settings1_3_covernoTOC_label {
            get {
                return ResourceManager.GetString("en_settings1_3_covernoTOC_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Embed font subset.
        /// </summary>
        internal static string en_settings1_3_embedFontSubset_label {
            get {
                return ResourceManager.GetString("en_settings1_3_embedFontSubset_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Create Flyleaf.
        /// </summary>
        internal static string en_settings1_3_flyleaf_label {
            get {
                return ResourceManager.GetString("en_settings1_3_flyleaf_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Generate corresponding MOBI file.
        /// </summary>
        internal static string en_settings1_3_generateMOBI_label {
            get {
                return ResourceManager.GetString("en_settings1_3_generateMOBI_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Chapter numbers to Chinese.
        /// </summary>
        internal static string en_settings1_3_replace_label {
            get {
                return ResourceManager.GetString("en_settings1_3_replace_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Simplified to Traditional.
        /// </summary>
        internal static string en_settings1_3_StT_label {
            get {
                return ResourceManager.GetString("en_settings1_3_StT_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Traditional to Simplified.
        /// </summary>
        internal static string en_settings1_3_TtS_label {
            get {
                return ResourceManager.GetString("en_settings1_3_TtS_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Vertical text direction.
        /// </summary>
        internal static string en_settings1_3_vertical_label {
            get {
                return ResourceManager.GetString("en_settings1_3_vertical_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Page Color.
        /// </summary>
        internal static string en_settings2_1_pc_label {
            get {
                return ResourceManager.GetString("en_settings2_1_pc_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Margin (B).
        /// </summary>
        internal static string en_settings2_2_pmD_label {
            get {
                return ResourceManager.GetString("en_settings2_2_pmD_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Margin (L).
        /// </summary>
        internal static string en_settings2_2_pmL_label {
            get {
                return ResourceManager.GetString("en_settings2_2_pmL_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Margin (R).
        /// </summary>
        internal static string en_settings2_2_pmR_label {
            get {
                return ResourceManager.GetString("en_settings2_2_pmR_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Margin (U).
        /// </summary>
        internal static string en_settings2_2_pmU_label {
            get {
                return ResourceManager.GetString("en_settings2_2_pmU_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Author.
        /// </summary>
        internal static string en_settings2_3_authornamefont_label {
            get {
                return ResourceManager.GetString("en_settings2_3_authornamefont_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Title.
        /// </summary>
        internal static string en_settings2_3_booknamefont_label {
            get {
                return ResourceManager.GetString("en_settings2_3_booknamefont_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cover Font Settings.
        /// </summary>
        internal static string en_settings2_tabItem1 {
            get {
                return ResourceManager.GetString("en_settings2_tabItem1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Page Settings.
        /// </summary>
        internal static string en_settings2_tabItem2 {
            get {
                return ResourceManager.GetString("en_settings2_tabItem2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Center.
        /// </summary>
        internal static string en_settings3_1_talign_center {
            get {
                return ResourceManager.GetString("en_settings3_1_talign_center", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Alignment: .
        /// </summary>
        internal static string en_settings3_1_talign_label {
            get {
                return ResourceManager.GetString("en_settings3_1_talign_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Left.
        /// </summary>
        internal static string en_settings3_1_talign_left {
            get {
                return ResourceManager.GetString("en_settings3_1_talign_left", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Right.
        /// </summary>
        internal static string en_settings3_1_talign_right {
            get {
                return ResourceManager.GetString("en_settings3_1_talign_right", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Color.
        /// </summary>
        internal static string en_settings3_1_tcolor_label {
            get {
                return ResourceManager.GetString("en_settings3_1_tcolor_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Font.
        /// </summary>
        internal static string en_settings3_1_tfont_label {
            get {
                return ResourceManager.GetString("en_settings3_1_tfont_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Color.
        /// </summary>
        internal static string en_settings3_2_bcolor_label {
            get {
                return ResourceManager.GetString("en_settings3_2_bcolor_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Font.
        /// </summary>
        internal static string en_settings3_2_bfont_label {
            get {
                return ResourceManager.GetString("en_settings3_2_bfont_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Add parag spacing.
        /// </summary>
        internal static string en_settings3_3_addparagraphspacing_label {
            get {
                return ResourceManager.GetString("en_settings3_3_addparagraphspacing_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Drop Cap.
        /// </summary>
        internal static string en_settings3_3_dropCap_label {
            get {
                return ResourceManager.GetString("en_settings3_3_dropCap_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Line spacing.
        /// </summary>
        internal static string en_settings3_3_linespacing_label {
            get {
                return ResourceManager.GetString("en_settings3_3_linespacing_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Stick-up Cap.
        /// </summary>
        internal static string en_settings3_3_stickupCap_label {
            get {
                return ResourceManager.GetString("en_settings3_3_stickupCap_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Body Content Settings.
        /// </summary>
        internal static string en_settings3_tabItem3 {
            get {
                return ResourceManager.GetString("en_settings3_tabItem3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Chapter Title Settings.
        /// </summary>
        internal static string en_settings3_tabItem4 {
            get {
                return ResourceManager.GetString("en_settings3_tabItem4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Choose.
        /// </summary>
        internal static string en_settings4_1_filelocation_button {
            get {
                return ResourceManager.GetString("en_settings4_1_filelocation_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Choose EPUB location.
        /// </summary>
        internal static string en_settings4_1_filelocation_dialog {
            get {
                return ResourceManager.GetString("en_settings4_1_filelocation_dialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на EPUB Location.
        /// </summary>
        internal static string en_settings4_1_filelocation_label {
            get {
                return ResourceManager.GetString("en_settings4_1_filelocation_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Delete temporary files.
        /// </summary>
        internal static string en_settings4_2_deletetempfiles_label {
            get {
                return ResourceManager.GetString("en_settings4_2_deletetempfiles_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Reset to default settings.
        /// </summary>
        internal static string en_settings4_3_reset_button {
            get {
                return ResourceManager.GetString("en_settings4_3_reset_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Manually check.
        /// </summary>
        internal static string en_settings4_4_chkupd_button {
            get {
                return ResourceManager.GetString("en_settings4_4_chkupd_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Automatically check for updates.
        /// </summary>
        internal static string en_settings4_4_chkupd_label {
            get {
                return ResourceManager.GetString("en_settings4_4_chkupd_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на UI Language has been changed.&lt;br/&gt;Please restart the app to see the effect!.
        /// </summary>
        internal static string en_settings4_4_language_changed {
            get {
                return ResourceManager.GetString("en_settings4_4_language_changed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на UI Language.
        /// </summary>
        internal static string en_settings4_4_language_label {
            get {
                return ResourceManager.GetString("en_settings4_4_language_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на TOC.
        /// </summary>
        internal static string en_TOC {
            get {
                return ResourceManager.GetString("en_TOC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Completed: .
        /// </summary>
        internal static string en_update_completed {
            get {
                return ResourceManager.GetString("en_update_completed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cur Version.
        /// </summary>
        internal static string en_update_cur {
            get {
                return ResourceManager.GetString("en_update_cur", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Update Description.
        /// </summary>
        internal static string en_update_description {
            get {
                return ResourceManager.GetString("en_update_description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Download Update.
        /// </summary>
        internal static string en_update_download {
            get {
                return ResourceManager.GetString("en_update_download", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Downloaded: .
        /// </summary>
        internal static string en_update_downloaded {
            get {
                return ResourceManager.GetString("en_update_downloaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Downloading Update ....
        /// </summary>
        internal static string en_update_downloading {
            get {
                return ResourceManager.GetString("en_update_downloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Update found!.
        /// </summary>
        internal static string en_update_found {
            get {
                return ResourceManager.GetString("en_update_found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Update found.
        /// </summary>
        internal static string en_update_found_title {
            get {
                return ResourceManager.GetString("en_update_found_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на New Version.
        /// </summary>
        internal static string en_update_new {
            get {
                return ResourceManager.GetString("en_update_new", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Verifying Update ....
        /// </summary>
        internal static string en_update_verifying {
            get {
                return ResourceManager.GetString("en_update_verifying", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 作者：.
        /// </summary>
        internal static string zh_about_author_label {
            get {
                return ResourceManager.GetString("zh_about_author_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 邮箱：.
        /// </summary>
        internal static string zh_about_email_label {
            get {
                return ResourceManager.GetString("zh_about_email_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 易笺（TestApp）是一款把TXT转换为EPUB的小工具。{0}如果有任何建议或者意见请发Email联系。{0}谢谢支持！.
        /// </summary>
        internal static string zh_about_intro {
            get {
                return ResourceManager.GetString("zh_about_intro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 简介：.
        /// </summary>
        internal static string zh_about_intro_label {
            get {
                return ResourceManager.GetString("zh_about_intro_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 版本：.
        /// </summary>
        internal static string zh_about_version_label {
            get {
                return ResourceManager.GetString("zh_about_version_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 窗口置顶.
        /// </summary>
        internal static string zh_AOT {
            get {
                return ResourceManager.GetString("zh_AOT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 取消置顶.
        /// </summary>
        internal static string zh_AOT_cancel {
            get {
                return ResourceManager.GetString("zh_AOT_cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 易笺.
        /// </summary>
        internal static string zh_app_name {
            get {
                return ResourceManager.GetString("zh_app_name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 更新出错！&lt;br/&gt;请稍后再试一次！.
        /// </summary>
        internal static string zh_autoUpdater_msg_failed {
            get {
                return ResourceManager.GetString("zh_autoUpdater_msg_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 更新出错.
        /// </summary>
        internal static string zh_autoUpdater_msg_failed_title {
            get {
                return ResourceManager.GetString("zh_autoUpdater_msg_failed_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 更新成功！&lt;br/&gt;程序5秒后即将自动重启！.
        /// </summary>
        internal static string zh_autoUpdater_msg_success {
            get {
                return ResourceManager.GetString("zh_autoUpdater_msg_success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 更新成功.
        /// </summary>
        internal static string zh_autoUpdater_msg_success_title {
            get {
                return ResourceManager.GetString("zh_autoUpdater_msg_success_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 更新过程被中断！&lt;br/&gt;无法完成更新！.
        /// </summary>
        internal static string zh_autoUpdater_msg_terminated {
            get {
                return ResourceManager.GetString("zh_autoUpdater_msg_terminated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 更新中断.
        /// </summary>
        internal static string zh_autoUpdater_msg_terminated_title {
            get {
                return ResourceManager.GetString("zh_autoUpdater_msg_terminated_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 已经是最新版本！.
        /// </summary>
        internal static string zh_autoUpdater_result_latest {
            get {
                return ResourceManager.GetString("zh_autoUpdater_result_latest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 没有找到更新信息！.
        /// </summary>
        internal static string zh_autoUpdater_result_none {
            get {
                return ResourceManager.GetString("zh_autoUpdater_result_none", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 已置顶.
        /// </summary>
        internal static string zh_balloontip_AOT {
            get {
                return ResourceManager.GetString("zh_balloontip_AOT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 已取消置顶.
        /// </summary>
        internal static string zh_balloontip_AOT_cancel {
            get {
                return ResourceManager.GetString("zh_balloontip_AOT_cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成失败！.
        /// </summary>
        internal static string zh_balloontip_fail {
            get {
                return ResourceManager.GetString("zh_balloontip_fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 文件名中无完整英文书名和作者信息！.
        /// </summary>
        internal static string zh_balloontip_NoEnTitleAuthor {
            get {
                return ResourceManager.GetString("zh_balloontip_NoEnTitleAuthor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 完整信息范例：“BookName By Author”{0}（一定要有“By”这个词，大小写不限）{0}将以文件名为书名，TestApp为作者名.
        /// </summary>
        internal static string zh_balloontip_NoEnTitleAuthor_detail {
            get {
                return ResourceManager.GetString("zh_balloontip_NoEnTitleAuthor_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 错误.
        /// </summary>
        internal static string zh_balloontip_NoHelpFile {
            get {
                return ResourceManager.GetString("zh_balloontip_NoHelpFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 帮助文件不存在！.
        /// </summary>
        internal static string zh_balloontip_NoHelpFile_detail {
            get {
                return ResourceManager.GetString("zh_balloontip_NoHelpFile_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 错误.
        /// </summary>
        internal static string zh_balloontip_NoKindleGen {
            get {
                return ResourceManager.GetString("zh_balloontip_NoKindleGen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на KindleGen.exe不存在！.
        /// </summary>
        internal static string zh_balloontip_NoKindleGen_detail {
            get {
                return ResourceManager.GetString("zh_balloontip_NoKindleGen_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 文件名中无完整书名和作者信息！.
        /// </summary>
        internal static string zh_balloontip_NoZhTitleAuthor {
            get {
                return ResourceManager.GetString("zh_balloontip_NoZhTitleAuthor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 完整信息范例：“《书名》作者：作者名”{0}（一定要有“作者”二字，书名号可以省略）{0}将以文件名为书名，TestApp为作者名.
        /// </summary>
        internal static string zh_balloontip_NoZhTitleAuthor_detail {
            get {
                return ResourceManager.GetString("zh_balloontip_NoZhTitleAuthor_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成完毕！.
        /// </summary>
        internal static string zh_balloontip_success {
            get {
                return ResourceManager.GetString("zh_balloontip_success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 温馨提示.
        /// </summary>
        internal static string zh_balloontip_title {
            get {
                return ResourceManager.GetString("zh_balloontip_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 目录提取完毕！.
        /// </summary>
        internal static string zh_balloontip_TOC_done {
            get {
                return ResourceManager.GetString("zh_balloontip_TOC_done", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 取消.
        /// </summary>
        internal static string zh_button_cancel {
            get {
                return ResourceManager.GetString("zh_button_cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 确定.
        /// </summary>
        internal static string zh_button_ok {
            get {
                return ResourceManager.GetString("zh_button_ok", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 显示/隐藏 .
        /// </summary>
        internal static string zh_contextual_menu_1 {
            get {
                return ResourceManager.GetString("zh_contextual_menu_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 退出.
        /// </summary>
        internal static string zh_contextual_menu_2 {
            get {
                return ResourceManager.GetString("zh_contextual_menu_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 加载设置文件出错，即将导入默认设置！.
        /// </summary>
        internal static string zh_event_setting_load_error {
            get {
                return ResourceManager.GetString("zh_event_setting_load_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 是否要还原默认设置？.
        /// </summary>
        internal static string zh_event_setting_reset {
            get {
                return ResourceManager.GetString("zh_event_setting_reset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 确认.
        /// </summary>
        internal static string zh_event_setting_reset_title {
            get {
                return ResourceManager.GetString("zh_event_setting_reset_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;font size=&quot;10&quot;&gt;&lt;b&gt;    关于    &lt;/b&gt;&lt;/font&gt;.
        /// </summary>
        internal static string zh_mainpage_about {
            get {
                return ResourceManager.GetString("zh_mainpage_about", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 窗口置顶.
        /// </summary>
        internal static string zh_mainpage_rm_item1 {
            get {
                return ResourceManager.GetString("zh_mainpage_rm_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 最小化.
        /// </summary>
        internal static string zh_mainpage_rm_item2 {
            get {
                return ResourceManager.GetString("zh_mainpage_rm_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 关闭.
        /// </summary>
        internal static string zh_mainpage_rm_item3 {
            get {
                return ResourceManager.GetString("zh_mainpage_rm_item3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;font size=&quot;10&quot;&gt;&lt;b&gt;    设置    &lt;/b&gt;&lt;/font&gt;.
        /// </summary>
        internal static string zh_mainpage_settings {
            get {
                return ResourceManager.GetString("zh_mainpage_settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;作者&lt;/b&gt;.
        /// </summary>
        internal static string zh_mainpage1_cover_author_label {
            get {
                return ResourceManager.GetString("zh_mainpage1_cover_author_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;书名&lt;/b&gt;.
        /// </summary>
        internal static string zh_mainpage1_cover_bookname_label {
            get {
                return ResourceManager.GetString("zh_mainpage1_cover_bookname_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;简介&lt;/b&gt;.
        /// </summary>
        internal static string zh_mainpage1_cover_intro_label {
            get {
                return ResourceManager.GetString("zh_mainpage1_cover_intro_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 拖拽文本文件到框内.
        /// </summary>
        internal static string zh_mainpage1_img1_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage1_img1_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 或者双击框内.
        /// </summary>
        internal static string zh_mainpage1_img1_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage1_img1_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 正在处理文件.
        /// </summary>
        internal static string zh_mainpage1_img2_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage1_img2_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 请稍等…….
        /// </summary>
        internal static string zh_mainpage1_img2_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage1_img2_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 文件选择成功！.
        /// </summary>
        internal static string zh_mainpage1_img3_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage1_img3_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 文本文件.
        /// </summary>
        internal static string zh_mainpage1_txt_click_filter {
            get {
                return ResourceManager.GetString("zh_mainpage1_txt_click_filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 请选择文本文件.
        /// </summary>
        internal static string zh_mainpage1_txt_click_title {
            get {
                return ResourceManager.GetString("zh_mainpage1_txt_click_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 只能拖入一个文件！.
        /// </summary>
        internal static string zh_mainpage1_txt_dragdrop_singlefile {
            get {
                return ResourceManager.GetString("zh_mainpage1_txt_dragdrop_singlefile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 只能拖入文本文件！.
        /// </summary>
        internal static string zh_mainpage1_txt_dragdrop_txtonly {
            get {
                return ResourceManager.GetString("zh_mainpage1_txt_dragdrop_txtonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 只能拖入图片文件！.
        /// </summary>
        internal static string zh_mainpage2_cover_dragdrop_imgonly {
            get {
                return ResourceManager.GetString("zh_mainpage2_cover_dragdrop_imgonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 只能拖入一个文件！.
        /// </summary>
        internal static string zh_mainpage2_cover_dragdrop_singlefile {
            get {
                return ResourceManager.GetString("zh_mainpage2_cover_dragdrop_singlefile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 删除原封面文件失败！.
        /// </summary>
        internal static string zh_mainpage2_helper_cover_delete_failed {
            get {
                return ResourceManager.GetString("zh_mainpage2_helper_cover_delete_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 图片质量值必须在0到100之间！.
        /// </summary>
        internal static string zh_mainpage2_helper_img_quality {
            get {
                return ResourceManager.GetString("zh_mainpage2_helper_img_quality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 删除标注图片错误！.
        /// </summary>
        internal static string zh_mainpage2_helper_notepic_delete_failed {
            get {
                return ResourceManager.GetString("zh_mainpage2_helper_notepic_delete_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 封面图片.
        /// </summary>
        internal static string zh_mainpage2_img_string {
            get {
                return ResourceManager.GetString("zh_mainpage2_img_string", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 操作无效！.
        /// </summary>
        internal static string zh_mainpage2_invalid_action {
            get {
                return ResourceManager.GetString("zh_mainpage2_invalid_action", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 导出目录.
        /// </summary>
        internal static string zh_mainpage2_rm1_item1 {
            get {
                return ResourceManager.GetString("zh_mainpage2_rm1_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 清空目录.
        /// </summary>
        internal static string zh_mainpage2_rm1_item2 {
            get {
                return ResourceManager.GetString("zh_mainpage2_rm1_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 导入目录.
        /// </summary>
        internal static string zh_mainpage2_rm1_item3 {
            get {
                return ResourceManager.GetString("zh_mainpage2_rm1_item3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 选中章节升一级.
        /// </summary>
        internal static string zh_mainpage2_rm2_item1 {
            get {
                return ResourceManager.GetString("zh_mainpage2_rm2_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 选中章节降一级.
        /// </summary>
        internal static string zh_mainpage2_rm2_item2 {
            get {
                return ResourceManager.GetString("zh_mainpage2_rm2_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 使用自动生成封面.
        /// </summary>
        internal static string zh_mainpage2_rm3_item1 {
            get {
                return ResourceManager.GetString("zh_mainpage2_rm3_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 选择封面图片.
        /// </summary>
        internal static string zh_mainpage2_rm3_item2 {
            get {
                return ResourceManager.GetString("zh_mainpage2_rm3_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 图片文件.
        /// </summary>
        internal static string zh_mainpage2_select_cover_filter {
            get {
                return ResourceManager.GetString("zh_mainpage2_select_cover_filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 请选择封面图片.
        /// </summary>
        internal static string zh_mainpage2_select_cover_title {
            get {
                return ResourceManager.GetString("zh_mainpage2_select_cover_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 清空目录.
        /// </summary>
        internal static string zh_mainpage2_TOC_clear {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_clear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 建议你按导出目录菜单以保存列表框中的数据{0}你确定要清空列表框中的数据？.
        /// </summary>
        internal static string zh_mainpage2_TOC_clear_confirm_detail {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_clear_confirm_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 确认.
        /// </summary>
        internal static string zh_mainpage2_TOC_clear_confirm_title {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_clear_confirm_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 目录是空的，无法清空！.
        /// </summary>
        internal static string zh_mainpage2_TOC_clear_invalid {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_clear_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 目录清空完毕！.
        /// </summary>
        internal static string zh_mainpage2_TOC_cleared {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_cleared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 只能拖入一个文件！.
        /// </summary>
        internal static string zh_mainpage2_TOC_dragdrop_singlefile {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_dragdrop_singlefile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 只能拖入文本文件！.
        /// </summary>
        internal static string zh_mainpage2_TOC_dragdrop_txtonly {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_dragdrop_txtonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 导出目录.
        /// </summary>
        internal static string zh_mainpage2_TOC_export {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_export", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 目录是空的，无法导出！.
        /// </summary>
        internal static string zh_mainpage2_TOC_export_invalid {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_export_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 目录导出到：.
        /// </summary>
        internal static string zh_mainpage2_TOC_exported {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_exported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 导入目录.
        /// </summary>
        internal static string zh_mainpage2_TOC_import {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_import", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 文本文件.
        /// </summary>
        internal static string zh_mainpage2_TOC_import_click_filter {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_import_click_filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 请选择目录文件.
        /// </summary>
        internal static string zh_mainpage2_TOC_import_click_title {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_import_click_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 无效的目录文件！.
        /// </summary>
        internal static string zh_mainpage2_TOC_import_invalid {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_import_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 目录导入完毕！.
        /// </summary>
        internal static string zh_mainpage2_TOC_imported {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_imported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 章节名称.
        /// </summary>
        internal static string zh_mainpage2_TOC_list_ChapterTitle {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_list_ChapterTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 行号.
        /// </summary>
        internal static string zh_mainpage2_TOC_list_LineNumber {
            get {
                return ResourceManager.GetString("zh_mainpage2_TOC_list_LineNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 作者.
        /// </summary>
        internal static string zh_mainpage3_bookauthor_label {
            get {
                return ResourceManager.GetString("zh_mainpage3_bookauthor_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 简介.
        /// </summary>
        internal static string zh_mainpage3_bookintro_label {
            get {
                return ResourceManager.GetString("zh_mainpage3_bookintro_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 书名.
        /// </summary>
        internal static string zh_mainpage3_bookname_label {
            get {
                return ResourceManager.GetString("zh_mainpage3_bookname_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 总字数.
        /// </summary>
        internal static string zh_mainpage3_bookwordcount_label {
            get {
                return ResourceManager.GetString("zh_mainpage3_bookwordcount_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 不重复字数.
        /// </summary>
        internal static string zh_mainpage3_bookwordcountnr_label {
            get {
                return ResourceManager.GetString("zh_mainpage3_bookwordcountnr_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 找不到.
        /// </summary>
        internal static string zh_mainpage3_copyImageFile_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_copyImageFile_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 文件！{0}无法继续生成！.
        /// </summary>
        internal static string zh_mainpage3_copyImageFile_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_copyImageFile_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 指定的正文字体不是TTF字体，无法嵌入！.
        /// </summary>
        internal static string zh_mainpage3_generateEpub_body_not_ttf {
            get {
                return ResourceManager.GetString("zh_mainpage3_generateEpub_body_not_ttf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 没有源文件！请拖入文本文件后重试！.
        /// </summary>
        internal static string zh_mainpage3_generateEpub_no_file {
            get {
                return ResourceManager.GetString("zh_mainpage3_generateEpub_no_file", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 指定的标题字体不是TTF字体，无法嵌入！.
        /// </summary>
        internal static string zh_mainpage3_generateEpub_title_not_ttf {
            get {
                return ResourceManager.GetString("zh_mainpage3_generateEpub_title_not_ttf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 不需要内嵌标题字体！.
        /// </summary>
        internal static string zh_mainpage3_helper_fontsubset_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_helper_fontsubset_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 不需要内嵌正文字体！.
        /// </summary>
        internal static string zh_mainpage3_helper_fontsubset_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_helper_fontsubset_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 字符太多！将用字体全集！.
        /// </summary>
        internal static string zh_mainpage3_helper_fontsubset_string3 {
            get {
                return ResourceManager.GetString("zh_mainpage3_helper_fontsubset_string3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 无效的目录！行号只能是数字！{0}无法继续生成Epub！.
        /// </summary>
        internal static string zh_mainpage3_helper_TOC_invalid {
            get {
                return ResourceManager.GetString("zh_mainpage3_helper_TOC_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;文件：&lt;/b&gt;.
        /// </summary>
        internal static string zh_mainpage3_location_label {
            get {
                return ResourceManager.GetString("zh_mainpage3_location_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ➢   下 本 书   ➣.
        /// </summary>
        internal static string zh_mainpage3_newbook_button {
            get {
                return ResourceManager.GetString("zh_mainpage3_newbook_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 正在生成…….
        /// </summary>
        internal static string zh_mainpage3_processing_label1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_processing_label1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成完毕！.
        /// </summary>
        internal static string zh_mainpage3_processing_label2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_processing_label2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成失败！！.
        /// </summary>
        internal static string zh_mainpage3_processing_label3 {
            get {
                return ResourceManager.GetString("zh_mainpage3_processing_label3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 加载设置.
        /// </summary>
        internal static string zh_mainpage3_stepItem1_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem1_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 加载字体、&lt;br/&gt;段落等设置.
        /// </summary>
        internal static string zh_mainpage3_stepItem1_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem1_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成HTML.
        /// </summary>
        internal static string zh_mainpage3_stepItem2_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem2_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 提取章节&lt;br/&gt;并生成HTML.
        /// </summary>
        internal static string zh_mainpage3_stepItem2_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem2_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成内嵌字体.
        /// </summary>
        internal static string zh_mainpage3_stepItem3_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem3_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 提取所有字符&lt;br/&gt;生成字体文件.
        /// </summary>
        internal static string zh_mainpage3_stepItem3_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem3_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成其它文件.
        /// </summary>
        internal static string zh_mainpage3_stepItem4_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem4_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成图片、CSS、OPF、&lt;br/&gt;NCX、MIMETYPE等.
        /// </summary>
        internal static string zh_mainpage3_stepItem4_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem4_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成EPUB.
        /// </summary>
        internal static string zh_mainpage3_stepItem5_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem5_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 打包所有文件，&lt;br/&gt;按照规则生成EPUB.
        /// </summary>
        internal static string zh_mainpage3_stepItem5_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem5_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成MOBI.
        /// </summary>
        internal static string zh_mainpage3_stepItem6_string1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem6_string1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 基于EPUB&lt;br/&gt;按照规则生成MOBI.
        /// </summary>
        internal static string zh_mainpage3_stepItem6_string2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_stepItem6_string2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;b&gt;耗时：&lt;/b&gt;.
        /// </summary>
        internal static string zh_mainpage3_time_label1 {
            get {
                return ResourceManager.GetString("zh_mainpage3_time_label1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 秒.
        /// </summary>
        internal static string zh_mainpage3_time_label2 {
            get {
                return ResourceManager.GetString("zh_mainpage3_time_label2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 电子书整体设置.
        /// </summary>
        internal static string zh_settings_item1 {
            get {
                return ResourceManager.GetString("zh_settings_item1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 页面设置.
        /// </summary>
        internal static string zh_settings_item2 {
            get {
                return ResourceManager.GetString("zh_settings_item2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 文字样式设置.
        /// </summary>
        internal static string zh_settings_item3 {
            get {
                return ResourceManager.GetString("zh_settings_item3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 其它设置.
        /// </summary>
        internal static string zh_settings_item4 {
            get {
                return ResourceManager.GetString("zh_settings_item4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на %.
        /// </summary>
        internal static string zh_settings_label_percentage {
            get {
                return ResourceManager.GetString("zh_settings_label_percentage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ⤒⤒          确    认    设    置          ⤒⤒.
        /// </summary>
        internal static string zh_settings_settings_done_button {
            get {
                return ResourceManager.GetString("zh_settings_settings_done_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 设置成功！.
        /// </summary>
        internal static string zh_settings_settings_success {
            get {
                return ResourceManager.GetString("zh_settings_settings_success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 封面作为电子书的第一页.
        /// </summary>
        internal static string zh_settings1_3_coverfirstpage_label {
            get {
                return ResourceManager.GetString("zh_settings1_3_coverfirstpage_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 封面不出现在目录里.
        /// </summary>
        internal static string zh_settings1_3_covernoTOC_label {
            get {
                return ResourceManager.GetString("zh_settings1_3_covernoTOC_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 嵌入字体（子集）.
        /// </summary>
        internal static string zh_settings1_3_embedFontSubset_label {
            get {
                return ResourceManager.GetString("zh_settings1_3_embedFontSubset_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 制作扉页.
        /// </summary>
        internal static string zh_settings1_3_flyleaf_label {
            get {
                return ResourceManager.GetString("zh_settings1_3_flyleaf_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 同时生成MOBI文件.
        /// </summary>
        internal static string zh_settings1_3_generateMOBI_label {
            get {
                return ResourceManager.GetString("zh_settings1_3_generateMOBI_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 替换标题中的数字为汉字.
        /// </summary>
        internal static string zh_settings1_3_replace_label {
            get {
                return ResourceManager.GetString("zh_settings1_3_replace_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 简体转繁体.
        /// </summary>
        internal static string zh_settings1_3_StT_label {
            get {
                return ResourceManager.GetString("zh_settings1_3_StT_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 繁体转简体.
        /// </summary>
        internal static string zh_settings1_3_TtS_label {
            get {
                return ResourceManager.GetString("zh_settings1_3_TtS_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 整本书竖排版.
        /// </summary>
        internal static string zh_settings1_3_vertical_label {
            get {
                return ResourceManager.GetString("zh_settings1_3_vertical_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 页面颜色：.
        /// </summary>
        internal static string zh_settings2_1_pc_label {
            get {
                return ResourceManager.GetString("zh_settings2_1_pc_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 下边距：.
        /// </summary>
        internal static string zh_settings2_2_pmD_label {
            get {
                return ResourceManager.GetString("zh_settings2_2_pmD_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 左边距：.
        /// </summary>
        internal static string zh_settings2_2_pmL_label {
            get {
                return ResourceManager.GetString("zh_settings2_2_pmL_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 右边距：.
        /// </summary>
        internal static string zh_settings2_2_pmR_label {
            get {
                return ResourceManager.GetString("zh_settings2_2_pmR_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 上边距：.
        /// </summary>
        internal static string zh_settings2_2_pmU_label {
            get {
                return ResourceManager.GetString("zh_settings2_2_pmU_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 作者字体：.
        /// </summary>
        internal static string zh_settings2_3_authornamefont_label {
            get {
                return ResourceManager.GetString("zh_settings2_3_authornamefont_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 书名字体：.
        /// </summary>
        internal static string zh_settings2_3_booknamefont_label {
            get {
                return ResourceManager.GetString("zh_settings2_3_booknamefont_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 封面设置.
        /// </summary>
        internal static string zh_settings2_tabItem1 {
            get {
                return ResourceManager.GetString("zh_settings2_tabItem1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 页面设置.
        /// </summary>
        internal static string zh_settings2_tabItem2 {
            get {
                return ResourceManager.GetString("zh_settings2_tabItem2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 居中.
        /// </summary>
        internal static string zh_settings3_1_talign_center {
            get {
                return ResourceManager.GetString("zh_settings3_1_talign_center", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 对齐方式：.
        /// </summary>
        internal static string zh_settings3_1_talign_label {
            get {
                return ResourceManager.GetString("zh_settings3_1_talign_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 居左.
        /// </summary>
        internal static string zh_settings3_1_talign_left {
            get {
                return ResourceManager.GetString("zh_settings3_1_talign_left", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 居右.
        /// </summary>
        internal static string zh_settings3_1_talign_right {
            get {
                return ResourceManager.GetString("zh_settings3_1_talign_right", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 标题颜色：.
        /// </summary>
        internal static string zh_settings3_1_tcolor_label {
            get {
                return ResourceManager.GetString("zh_settings3_1_tcolor_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 标题字体：.
        /// </summary>
        internal static string zh_settings3_1_tfont_label {
            get {
                return ResourceManager.GetString("zh_settings3_1_tfont_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 正文颜色：.
        /// </summary>
        internal static string zh_settings3_2_bcolor_label {
            get {
                return ResourceManager.GetString("zh_settings3_2_bcolor_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 正文字体：.
        /// </summary>
        internal static string zh_settings3_2_bfont_label {
            get {
                return ResourceManager.GetString("zh_settings3_2_bfont_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 增加段落前后的间距.
        /// </summary>
        internal static string zh_settings3_3_addparagraphspacing_label {
            get {
                return ResourceManager.GetString("zh_settings3_3_addparagraphspacing_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 章节首字母下沉.
        /// </summary>
        internal static string zh_settings3_3_dropCap_label {
            get {
                return ResourceManager.GetString("zh_settings3_3_dropCap_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 行距：.
        /// </summary>
        internal static string zh_settings3_3_linespacing_label {
            get {
                return ResourceManager.GetString("zh_settings3_3_linespacing_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 章节首字母上升.
        /// </summary>
        internal static string zh_settings3_3_stickupCap_label {
            get {
                return ResourceManager.GetString("zh_settings3_3_stickupCap_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 正文设置.
        /// </summary>
        internal static string zh_settings3_tabItem3 {
            get {
                return ResourceManager.GetString("zh_settings3_tabItem3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 标题设置.
        /// </summary>
        internal static string zh_settings3_tabItem4 {
            get {
                return ResourceManager.GetString("zh_settings3_tabItem4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 选择.
        /// </summary>
        internal static string zh_settings4_1_filelocation_button {
            get {
                return ResourceManager.GetString("zh_settings4_1_filelocation_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 选择文件生成目录.
        /// </summary>
        internal static string zh_settings4_1_filelocation_dialog {
            get {
                return ResourceManager.GetString("zh_settings4_1_filelocation_dialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 生成文件位置：.
        /// </summary>
        internal static string zh_settings4_1_filelocation_label {
            get {
                return ResourceManager.GetString("zh_settings4_1_filelocation_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 删除转换过程中的临时文件.
        /// </summary>
        internal static string zh_settings4_2_deletetempfiles_label {
            get {
                return ResourceManager.GetString("zh_settings4_2_deletetempfiles_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 还原为默认设置.
        /// </summary>
        internal static string zh_settings4_3_reset_button {
            get {
                return ResourceManager.GetString("zh_settings4_3_reset_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 手动检测更新.
        /// </summary>
        internal static string zh_settings4_4_chkupd_button {
            get {
                return ResourceManager.GetString("zh_settings4_4_chkupd_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 程序启动时自动检测更新.
        /// </summary>
        internal static string zh_settings4_4_chkupd_label {
            get {
                return ResourceManager.GetString("zh_settings4_4_chkupd_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 界面语言已被更改&lt;br/&gt;程序重启后生效！.
        /// </summary>
        internal static string zh_settings4_4_language_changed {
            get {
                return ResourceManager.GetString("zh_settings4_4_language_changed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 界面语言：.
        /// </summary>
        internal static string zh_settings4_4_language_label {
            get {
                return ResourceManager.GetString("zh_settings4_4_language_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 目录.
        /// </summary>
        internal static string zh_TOC {
            get {
                return ResourceManager.GetString("zh_TOC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 已完成：.
        /// </summary>
        internal static string zh_update_completed {
            get {
                return ResourceManager.GetString("zh_update_completed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 当前版本.
        /// </summary>
        internal static string zh_update_cur {
            get {
                return ResourceManager.GetString("zh_update_cur", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 更新内容.
        /// </summary>
        internal static string zh_update_description {
            get {
                return ResourceManager.GetString("zh_update_description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 下载更新.
        /// </summary>
        internal static string zh_update_download {
            get {
                return ResourceManager.GetString("zh_update_download", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 已下载：.
        /// </summary>
        internal static string zh_update_downloaded {
            get {
                return ResourceManager.GetString("zh_update_downloaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 正在下载更新…….
        /// </summary>
        internal static string zh_update_downloading {
            get {
                return ResourceManager.GetString("zh_update_downloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 有新版本发布！.
        /// </summary>
        internal static string zh_update_found {
            get {
                return ResourceManager.GetString("zh_update_found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 检测到更新.
        /// </summary>
        internal static string zh_update_found_title {
            get {
                return ResourceManager.GetString("zh_update_found_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 更新版本.
        /// </summary>
        internal static string zh_update_new {
            get {
                return ResourceManager.GetString("zh_update_new", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 验证更新…….
        /// </summary>
        internal static string zh_update_verifying {
            get {
                return ResourceManager.GetString("zh_update_verifying", resourceCulture);
            }
        }
    }
}
