using System;
using System.Runtime.CompilerServices;
using NAudio.Wave;

namespace Brute
{
	// Token: 0x02000011 RID: 17
	public class LoopStream : WaveStream
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00008D6C File Offset: 0x00006F6C
		public LoopStream(WaveStream sourceStream)
		{
			this.JEWQFLUJTSHYLHRJSAKQVA = sourceStream;
			this.EnableLooping = true;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00008D84 File Offset: 0x00006F84
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00008D98 File Offset: 0x00006F98
		public bool EnableLooping { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00008DA4 File Offset: 0x00006FA4
		public override WaveFormat WaveFormat
		{
			get
			{
				return this.JEWQFLUJTSHYLHRJSAKQVA.WaveFormat;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00008DC0 File Offset: 0x00006FC0
		public override long Length
		{
			get
			{
				return this.JEWQFLUJTSHYLHRJSAKQVA.Length;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00008DDC File Offset: 0x00006FDC
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00008DF8 File Offset: 0x00006FF8
		public override long Position
		{
			get
			{
				return this.JEWQFLUJTSHYLHRJSAKQVA.Position;
			}
			set
			{
				this.JEWQFLUJTSHYLHRJSAKQVA.Position = value;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00008E08 File Offset: 0x00007008
		public override int Read(byte[] buffer, int offset, int count)
		{
			int i;
			int num;
			for (i = 0; i < count; i += num)
			{
				num = this.JEWQFLUJTSHYLHRJSAKQVA.Read(buffer, offset + i, count - i);
				if (num == 0)
				{
					if (this.JEWQFLUJTSHYLHRJSAKQVA.Position == 0L || !this.EnableLooping)
					{
						break;
					}
					this.JEWQFLUJTSHYLHRJSAKQVA.Position = 0L;
				}
			}
			return i;
		}

		// Token: 0x04000087 RID: 135
		private WaveStream JEWQFLUJTSHYLHRJSAKQVA;

		// Token: 0x04000088 RID: 136
		[CompilerGenerated]
		private bool WEDLHFPPPGBJCPRKQNFOFY;
	}
}
