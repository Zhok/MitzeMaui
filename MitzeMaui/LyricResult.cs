// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.chartlyrics.com/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.chartlyrics.com/", IsNullable = false)]
public partial class GetLyricResult
{

    private byte trackIdField;

    private string lyricChecksumField;

    private ushort lyricIdField;

    private string lyricSongField;

    private string lyricArtistField;

    private string lyricUrlField;

    private string lyricCovertArtUrlField;

    private byte lyricRankField;

    private string lyricCorrectUrlField;

    private string lyricField;

    /// <remarks/>
    public byte TrackId
    {
        get
        {
            return this.trackIdField;
        }
        set
        {
            this.trackIdField = value;
        }
    }

    /// <remarks/>
    public string LyricChecksum
    {
        get
        {
            return this.lyricChecksumField;
        }
        set
        {
            this.lyricChecksumField = value;
        }
    }

    /// <remarks/>
    public ushort LyricId
    {
        get
        {
            return this.lyricIdField;
        }
        set
        {
            this.lyricIdField = value;
        }
    }

    /// <remarks/>
    public string LyricSong
    {
        get
        {
            return this.lyricSongField;
        }
        set
        {
            this.lyricSongField = value;
        }
    }

    /// <remarks/>
    public string LyricArtist
    {
        get
        {
            return this.lyricArtistField;
        }
        set
        {
            this.lyricArtistField = value;
        }
    }

    /// <remarks/>
    public string LyricUrl
    {
        get
        {
            return this.lyricUrlField;
        }
        set
        {
            this.lyricUrlField = value;
        }
    }

    /// <remarks/>
    public string LyricCovertArtUrl
    {
        get
        {
            return this.lyricCovertArtUrlField;
        }
        set
        {
            this.lyricCovertArtUrlField = value;
        }
    }

    /// <remarks/>
    public byte LyricRank
    {
        get
        {
            return this.lyricRankField;
        }
        set
        {
            this.lyricRankField = value;
        }
    }

    /// <remarks/>
    public string LyricCorrectUrl
    {
        get
        {
            return this.lyricCorrectUrlField;
        }
        set
        {
            this.lyricCorrectUrlField = value;
        }
    }

    /// <remarks/>
    public string Lyric
    {
        get
        {
            return this.lyricField;
        }
        set
        {
            this.lyricField = value;
        }
    }
}

