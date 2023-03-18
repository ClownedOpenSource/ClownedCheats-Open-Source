using Clowned_OpenSource.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clowned_OpenSource.Games
{
    public partial class SSOPanel : Form
    {
        #region Adresse
        private static offset o = new offset();
        private class offset
        {
            public string Cheat_FlyUP;
            public string Cheat_ExtremeSpeed;
            public string Cheat_CustomSpeed;
            public string Cheat_NoFall;
            public string Cheat_NoReset;
            public string Cheat_CoordsXYZ;
            public string Cheat_InstantWin;

            public string Modding_MAPBUTTON;
            public string Modding_INVENTARBUTTON;
            public string Modding_CHARACTERBUTTON;
            public string Modding_QUESTLOGBUTTON;
            public string Modding_COLLECTIONBUTTON;
            public string Modding_PHONEBUTTON;
            public string Modding_MAXBUTTON;
            public string Modding_CLUBBUTTON;
            public string Modding_MINBUTTON;
            public string Modding_HIGHSCORESBUTTON;
            public string Modding_FRIENDSBUTTON;
            public string Modding_GLOBALSHOPBUTTON;

            public string Addresse_Modding = "None";
        }
        #endregion

        #region FindAdresse
        internal async Task AOBScan()
        {
            var delay = 10;

            MessageBox.Show("We scanning now... Please wait little");

            await Task.Delay(delay);

            //long FlyUpAddr = HelpMisc.mem.AoBScan(0x600000000000, 0x800000000000, ProtectString.Decrypt("WJiyGBd7v2EY4+17b/lBZaWZGMn3cKc5FtyogjwnKaKbJtWV2a3usA=="), true, true).Result.FirstOrDefault();
            //o.Cheat_FlyUP = $"{FlyUpAddr:X}";
            //await Task.Delay(delay);

            //long ExtremeSpeedAddr = HelpMisc.mem.AoBScan(0x600000000000, 0x800000000000, ProtectString.Decrypt("Hjir4MXRVssAbjYyqAKd32hGExpmVO8dwVHBN1O1Wsw="), true, true).Result.FirstOrDefault();
            //o.Cheat_ExtremeSpeed = $"{ExtremeSpeedAddr:X}";
            //await Task.Delay(delay);

            //long InstantWinAddr = HelpMisc.mem.AoBScan(ProtectString.Decrypt("NAW2hUrFx/qvAgjHFPBECdUsbrjSNvj4Duy+W6D2Hyj3RpsfF2faaw=="), true, true).Result.FirstOrDefault();
            //o.Cheat_InstantWin = $"{InstantWinAddr:X}";
            //await Task.Delay(delay);

            long UIButtonMapAddr = HelpMisc.mem.AoBScan("69 66 28 20 67 6C 6F 62 61 6C 2F 4D 61 70 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 4D 61 70 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 4D 61 70 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 22 4D 69 6E 69 4D 61 70 56 69 65 77 42 75 74 74 6F 6E 22 29 3B 20 2F 2F 20 43 75 73 74 6F 6D 20 4E 61 6D 65 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_MAPBUTTON = $"{UIButtonMapAddr:X}";
            await Task.Delay(delay);

            long UIButtonInvAddr = HelpMisc.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 49 6E 76 65 6E 74 6F 72 79 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 49 6E 76 65 6E 74 6F 72 79 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 49 6E 76 65 6E 74 6F 72 79 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 54 69 70 36 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 54 69 70 36 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_INVENTARBUTTON = $"{UIButtonInvAddr:X}";
            await Task.Delay(delay);

            long UIButtonMainMenuAddr = HelpMisc.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 67 6C 6F 62 61 6C 2F 4D 61 69 6E 4D 65 6E 75 2E 53 74 61 72 74 28 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 54 69 70 38 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 54 69 70 38 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_PHONEBUTTON = $"{UIButtonMainMenuAddr:X}";
            await Task.Delay(delay);

            long UIButtonHighScoreAddr = HelpMisc.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 48 69 67 68 73 63 6F 72 65 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 48 69 67 68 73 63 6F 72 65 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 48 69 67 68 73 63 6F 72 65 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_HIGHSCORESBUTTON = $"{UIButtonHighScoreAddr:X}";
            await Task.Delay(delay);

            long UIButtonFriendsAddr = HelpMisc.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 53 6F 63 69 61 6C 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 53 6F 63 69 61 6C 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 53 6F 63 69 61 6C 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 74 68 69 73 2F 4E 6F 74 69 66 79 45 66 66 65 63 74 2E 53 74 6F 70 28 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_FRIENDSBUTTON = $"{UIButtonFriendsAddr:X}";
            await Task.Delay(delay);

            long UIButtonClubAddr = HelpMisc.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 43 6C 75 62 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 43 6C 75 62 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 43 6C 75 62 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_CLUBBUTTON = $"{UIButtonClubAddr:X}";
            await Task.Delay(delay);

            long UIButtonCollectionsAddr = HelpMisc.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 67 6C 6F 62 61 6C 2F 43 6F 6C 6C 65 63 74 69 6F 6E 56 69 65 77 47 72 6F 75 70 2E 54 6F 67 67 6C 65 56 69 65 77 47 72 6F 75 70 28 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_COLLECTIONBUTTON = $"{UIButtonCollectionsAddr:X}";
            await Task.Delay(delay);

            long UIButtonQuestLogsAddr = HelpMisc.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 51 75 65 73 74 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 51 75 65 73 74 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 51 75 65 73 74 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_QUESTLOGBUTTON = $"{UIButtonQuestLogsAddr:X}";
            await Task.Delay(delay);

            long UIButtonMapMinAddr = HelpMisc.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 70 61 72 65 6E 74 2F 4D 69 6E 69 4D 61 70 56 69 65 77 2E 41 64 64 54 65 72 72 61 69 6E 4D 61 70 56 69 65 77 53 63 61 6C 65 28 2D 30 2E 31 32 35 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_MINBUTTON = $"{UIButtonMapMinAddr:X}";
            await Task.Delay(delay);

            long UIButtonMapMaxAddr = HelpMisc.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 70 61 72 65 6E 74 2F 4D 69 6E 69 4D 61 70 56 69 65 77 2E 41 64 64 54 65 72 72 61 69 6E 4D 61 70 56 69 65 77 53 63 61 6C 65 28 30 2E 31 32 35 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_MAXBUTTON = $"{UIButtonMapMaxAddr:X}";
            await Task.Delay(delay);

            long UIButtonCharacterAddr = HelpMisc.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 43 68 61 72 61 63 74 65 72 53 68 65 65 74 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 43 68 61 72 61 63 74 65 72 53 68 65 65 74 2E 53 74 6F 70 28 29 3B 0D 0A 09 67 6C 6F 62 61 6C 2F 48 6F 72 73 65 53 68 65 65 74 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 43 68 61 72 61 63 74 65 72 53 68 65 65 74 2E 53 74 61 72 74 28 29 3B 0D 0A 09 67 6C 6F 62 61 6C 2F 48 6F 72 73 65 2E 48 6F 72 73 65 49 6E 73 70 65 63 74 48 6F 72 73 65 28 29 3B 0D 0A 7D 0D 0A 0D 0A 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 54 69 70 35 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 54 69 70 35 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_CHARACTERBUTTON = $"{UIButtonCharacterAddr:X}";
            await Task.Delay(delay);

            long UIButtonglobalshopAddr = HelpMisc.mem.AoBScan("67 6C 6F 62 61 6C 2F 50 6C 61 79 65 72 2E 43 6C 6F 73 65 41 6C 6C 57 69 6E 64 6F 77 73 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 43 53 49 4D 61 69 6E 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            o.Modding_GLOBALSHOPBUTTON = $"{UIButtonglobalshopAddr:X}";
            await Task.Delay(delay);

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox4.Enabled = true;
            groupBox6.Enabled = true;

            MessageBox.Show("We are done, have fun");

            GameCheck.Start();
        }
        #endregion

        #region ModdingWrite
        internal void Modding(string script)
        {
            var Message = $"global/InfoTextWindowNoAutoStop.SetViewText(\"{MiddleScreenText.Text}\");global/InfoTextWindowNoAutoStop.Start();global/LocationNameMiniMap.SetViewText(\"{MapTooltipText.Text}, by ClownedCheats\");"; // Middle

            if (o.Addresse_Modding == "None") { MessageBox.Show("Please First Select then Press Button! \n(Custom Error Code: 0x00000099)"); return; }
            if (o.Addresse_Modding == "MAP_BUTTON") { HelpMisc.mem.WriteString(o.Modding_MAPBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "INVENTAR_BUTTON") { HelpMisc.mem.WriteString(o.Modding_INVENTARBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "CHARACTER_BUTTON") { HelpMisc.mem.WriteString(o.Modding_CHARACTERBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "QUESTLOG_BUTTON") { HelpMisc.mem.WriteString(o.Modding_QUESTLOGBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "COLLECTION_BUTTON") { HelpMisc.mem.WriteString(o.Modding_COLLECTIONBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "PHONE_BUTTON") { HelpMisc.mem.WriteString(o.Modding_PHONEBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "ZOOM_MAX_BUTTON") { HelpMisc.mem.WriteString(o.Modding_MAXBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "CLUB_BUTTON") { HelpMisc.mem.WriteString(o.Modding_CLUBBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "ZOOM_MIN_BUTTON") { HelpMisc.mem.WriteString(o.Modding_MINBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "HIGHSCORES_BUTTON") { HelpMisc.mem.WriteString(o.Modding_HIGHSCORESBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "FRIENDS_BUTTON") { HelpMisc.mem.WriteString(o.Modding_FRIENDSBUTTON, Message + script + "\0"); }
            if (o.Addresse_Modding == "GLOBALSHOP_BUTTON") { HelpMisc.mem.WriteString(o.Modding_GLOBALSHOPBUTTON, Message + script + "\0"); }
        }
        #endregion

        #region Form
        public SSOPanel()
        {
            InitializeComponent();
        }

        private void SSOPanel_Load(object sender, EventArgs e)
        {

        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            AOBScan();
        }
        #endregion

        #region ModdingButton
        private void ModWriteScriptButton_Click(object sender, EventArgs e)
        {
            Modding(textBox1.Text);
        }

        private void ModPlayerXPButton_Click(object sender, EventArgs e)
        {
            Modding("global/QuestManager/Episode1/Chain20/E01_Quest_L08_C020_011.QuestComplete();");
        }

        private void ModHorseLevelButton_Click(object sender, EventArgs e)
        {
            Modding($"global/Horse.SetHorseLevel({textBox4.Text});");
        }

        private void ModPlayerLevelButton_Click(object sender, EventArgs e)
        {
            Modding($"global/Player.SetPlayerTPNetLevel({textBox3.Text});");
        }

        private void ModSpawnFjordButton_Click(object sender, EventArgs e)
        {
            Modding("global/Fjording1.SetPositionY(93.02);" +
                "global/Fjording2.SetPositionY(93.02);" +
                "global/Fjording3.SetPositionY(93.02);" +
                "global/Fjording4.SetPositionY(93.02);" +
                "global/Fjording5.SetPositionY(93.02);" +
                "global/Fjording6.SetPositionY(93.02);" +
                "global/Fjording7.SetPositionY(93.02);" +
                "global/Fjording8.SetPositionY(93.02);");
        }

        private void ModGameMasterButton_Click(object sender, EventArgs e)
        {
            Modding("global/GMUI.FileObjectUnLoad();" +
                "global/GMUI.FileObjectLoad();" +
                "global/GMUI/Timer.SetActive(0);" +
                "global/GMWindow.Start();");
        }

        private void ModHairSalonButton_Click(object sender, EventArgs e)
        {
            Modding("global/MirrorWindow.Start();");
        }

        private void ModDebugButton_Click(object sender, EventArgs e)
        {
            Modding("global/HannesDebugMenu.FileObjectLoad();" +
                "global/HannesDebugMenu.SetActive(1);" +
                "global/HannesDebugMenu.Start();");
        }

        private void ModDruidDebugButton_Click(object sender, EventArgs e)
        {
            Modding("global/Debug_DruidMissionsTaskBoard.Start();");
        }

        private void ModFarahsWorkshopButton_Click(object sender, EventArgs e)
        {
            Modding("global/Debug_FarahsWorkshop.Start();");
        }

        private void ModCarButton_Click(object sender, EventArgs e)
        {
            Modding("global/AprilFools2019_HorseAsCar.FileObjectLoad();");
        }

        private void ModFlyingHorseButton_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.SetRelativeLinearVelocity(0,10,20);");
        }

        private void ModInstantRideButton_Click(object sender, EventArgs e)
        {
            Modding("global/Player.PlayerTPNetEnterVehicle(global/Horse);");
        }

        private void ModHideAllButton_Click(object sender, EventArgs e)
        {
            Modding("global/Network.SetNetworkHideSlaves(1);");
        }

        private void ModShowAllButton_Click(object sender, EventArgs e)
        {
            Modding("global/Network.SetNetworkHideSlaves(0);");
        }

        private void ModPetBreadButton_Click(object sender, EventArgs e)
        {
            Modding("global/QuestManager/Episode1/Chain6004/E01_Quest_L01_C6004_010.QuestComplete();" +
                "global/PlayerItemManager/Pet/Pet/CompanionBread_AprilsFools_2018.SetMovable(1);");
        }

        private void ModJorvikSchillingsButton_Click(object sender, EventArgs e)
        {
            Modding("global/QuestManager/Episode1/Chain2231/E01_Quest_L01_C2231_001.QuestComplete();");
        }

        private void ModHorseXPButton_Click(object sender, EventArgs e)
        {
            Modding("global/QuestManager/Episode1/Chain9007/E01_Quest_L01_C9007_010.QuestComplete();");
        }

        private void ModFakeStarCoinsButton_Click(object sender, EventArgs e)
        {
            Modding($"global/PlayerStarMoney.AddDataInt({textBox5.Text});");
        }

        private void ModRandomColorBothButton_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.HorseAppearanceCustomBody(2,-1,0);" +
                "global/Horse.HorseAppearanceCustomHair(3,-1,0);");
        }

        private void ModRandomColorManeButton_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.HorseAppearanceCustomHair(3,-1,0);");
        }

        private void ModRandomColorBodyButton_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.HorseAppearanceCustomBody(2,-1,0);");
        }

        private void ModRainbowZeeButton_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.HorseAppearanceCustomBody(10,0,0);" +
                "global/Horse.HorseAppearanceCustomHair(3,4,0);");
        }

        private void ModWardrobeButton_Click(object sender, EventArgs e)
        {
            Modding("global/MyStableWindow.Start();");
        }

        private void ModHorseNameButton_Click(object sender, EventArgs e)
        {
            Modding($@"global/HorseName.SetDataString(""{textBox7.Text}"");");
        }

        private void ModPlayerNameButton_Click(object sender, EventArgs e)
        {
            Modding($@"global/PlayerName.SetDataString(""{textBox6.Text}"");");
        }

        private void ModHorseIDsShopButton_Click(object sender, EventArgs e)
        {
            Modding("global/HorseForSaleInfoWindow.Start();" +
                $"global/HorseForSaleInfoWindow/RenderViews/RenderTargetView/Scene/Animation/Horse.CloneHorse({comboBox6.Text}, 1);" +
                "global/HorseForSaleInfoWindow/RenderViews/RenderTargetView/Scene/Animation/Horse.HorseForSaleStartBuyWindow();");
        }

        private void ModHorseIDsChangeButton_Click(object sender, EventArgs e)
        {
            Modding($"global/Horse.CloneHorseAppearance({comboBox5.Text});");
        }

        private void ModHorseAnimationButton_Click(object sender, EventArgs e)
        {
            Modding($@"global/Horse/Skin/Pelvis.SetSkinMeshAnimation(""{comboBox4.Text}"");");
        }

        private void ModPlayerAnimationButton_Click(object sender, EventArgs e)
        {
            Modding($@"global/Player.PlayerTPNetPlayAnimationLooping(""{comboBox3.Text}"");");
        }

        private void ModShopOpenButton_Click(object sender, EventArgs e)
        {
            Modding($"global/ShopManager/Episode1/{comboBox2.Text}.ShopOpen();");
        }

        private void ModQuestCompleteButton_Click(object sender, EventArgs e)
        {
            Modding($"global/QuestManager/Episode1/{comboBox1.Text}.QuestComplete();");
        }
        #endregion

        #region ModdingSelectButton
        private void SelectButtonMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectButtonMod.SelectedItem == "Map")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_MAPBUTTON) == 0)) { o.Addresse_Modding = "MAP_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "Inventar")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_INVENTARBUTTON) == 0)) { o.Addresse_Modding = "INVENTAR_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "Character")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_CHARACTERBUTTON) == 0)) { o.Addresse_Modding = "CHARACTER_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "QuestLogs")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_QUESTLOGBUTTON) == 0)) { o.Addresse_Modding = "QUESTLOG_BUTTON"; }   
            }
            if (SelectButtonMod.SelectedItem == "Collection")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_COLLECTIONBUTTON) == 0)) { o.Addresse_Modding = "COLLECTION_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "Phone")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_PHONEBUTTON) == 0)) { o.Addresse_Modding = "PHONE_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "Max Zoom")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_MAXBUTTON) == 0)) { o.Addresse_Modding = "ZOOM_MAX_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "Club")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_CLUBBUTTON) == 0)) { o.Addresse_Modding = "CLUB_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "Min Zoom")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_MINBUTTON) == 0)) { o.Addresse_Modding = "ZOOM_MIN_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "HighScore")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_HIGHSCORESBUTTON) == 0)) { o.Addresse_Modding = "HIGHSCORES_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "Friends")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_FRIENDSBUTTON) == 0)) { o.Addresse_Modding = "FRIENDS_BUTTON"; }
            }
            if (SelectButtonMod.SelectedItem == "Globalshop")
            {
                if (!Convert.ToBoolean(HelpMisc.mem.ReadByte(o.Modding_GLOBALSHOPBUTTON) == 0)) { o.Addresse_Modding = "GLOBALSHOP_BUTTON"; }
            }
        }
        #endregion

        private void GameCheck_Tick(object sender, EventArgs e)
        {

        }
    }
}
