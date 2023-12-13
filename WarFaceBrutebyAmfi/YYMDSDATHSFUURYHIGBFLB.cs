using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using xNet.Net;

// Token: 0x0200000D RID: 13
internal class YYMDSDATHSFUURYHIGBFLB
{
	// Token: 0x06000059 RID: 89 RVA: 0x00006A08 File Offset: 0x00004C08
	public static void JGEHMNSBTPIBDJFFBAMWCE(string ZIBDPTNSHPNWDSJGKEYOLL, string PTWFVZGJBYXFYWTZSMPVJ)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(ZIBDPTNSHPNWDSJGKEYOLL, true);
			streamWriter.WriteLine(PTWFVZGJBYXFYWTZSMPVJ);
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00006A4C File Offset: 0x00004C4C
	public static string DLTIRZPFENHSYBSSPWDWGB()
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "*.txt | *.txt";
		openFileDialog.ShowDialog();
		return openFileDialog.FileName;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00006A7C File Offset: 0x00004C7C
	public static object[] GOAWITHDICOJFROQFDVSKZ(string VEIQIYMVVFONDNBLVBDUNZ)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.AddRange(File.ReadAllLines(VEIQIYMVVFONDNBLVBDUNZ));
		return arrayList.ToArray();
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00006AA4 File Offset: 0x00004CA4
	public static ProxyClient UAPHGNGMPKNJUNCFETIASS(int URYQBGTNUOSDXTURTLAJVU)
	{
		ProxyClient result;
		if (!ZUKPFWCFAUTRSGGDNAPJX.IZRXIVKWPKCMTYCEAPHLCD)
		{
			result = null;
		}
		else
		{
			switch (ZUKPFWCFAUTRSGGDNAPJX.MXXWTDHFGCXOVUKRSOBJNO)
			{
			case 0:
				result = ProxyClient.Parse(ProxyType.Http, ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP[URYQBGTNUOSDXTURTLAJVU].ToString());
				break;
			case 1:
				result = ProxyClient.Parse(ProxyType.Socks4, ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP[URYQBGTNUOSDXTURTLAJVU].ToString());
				break;
			case 2:
				result = ProxyClient.Parse(ProxyType.Socks5, ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP[URYQBGTNUOSDXTURTLAJVU].ToString());
				break;
			default:
				result = ProxyClient.Parse(ProxyType.Http, ZUKPFWCFAUTRSGGDNAPJX.PNVITANWZWGYNKSSZJUWP[URYQBGTNUOSDXTURTLAJVU].ToString());
				break;
			}
		}
		return result;
	}
}
