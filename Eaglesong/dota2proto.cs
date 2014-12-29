// Generated from: dota2.proto
namespace dota2
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoFileHeader")]
  public partial class CDemoFileHeader : global::ProtoBuf.IExtensible
  {
    public CDemoFileHeader() {}
    
    private string _demo_file_stamp;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"demo_file_stamp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string demo_file_stamp
    {
      get { return _demo_file_stamp; }
      set { _demo_file_stamp = value; }
    }
    private int _network_protocol = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"network_protocol", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int network_protocol
    {
      get { return _network_protocol; }
      set { _network_protocol = value; }
    }
    private string _server_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"server_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string server_name
    {
      get { return _server_name; }
      set { _server_name = value; }
    }
    private string _client_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"client_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string client_name
    {
      get { return _client_name; }
      set { _client_name = value; }
    }
    private string _map_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"map_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string map_name
    {
      get { return _map_name; }
      set { _map_name = value; }
    }
    private string _game_directory = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"game_directory", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string game_directory
    {
      get { return _game_directory; }
      set { _game_directory = value; }
    }
    private int _fullpackets_version = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"fullpackets_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int fullpackets_version
    {
      get { return _fullpackets_version; }
      set { _fullpackets_version = value; }
    }
    private bool _allow_clientside_entities = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"allow_clientside_entities", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool allow_clientside_entities
    {
      get { return _allow_clientside_entities; }
      set { _allow_clientside_entities = value; }
    }
    private bool _allow_clientside_particles = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"allow_clientside_particles", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool allow_clientside_particles
    {
      get { return _allow_clientside_particles; }
      set { _allow_clientside_particles = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGameInfo")]
  public partial class CGameInfo : global::ProtoBuf.IExtensible
  {
    public CGameInfo() {}
    
    private CGameInfo.CDotaGameInfo _dota = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"dota", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CGameInfo.CDotaGameInfo dota
    {
      get { return _dota; }
      set { _dota = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDotaGameInfo")]
  public partial class CDotaGameInfo : global::ProtoBuf.IExtensible
  {
    public CDotaGameInfo() {}
    
    private uint _match_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint match_id
    {
      get { return _match_id; }
      set { _match_id = value; }
    }
    private int _game_mode = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"game_mode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int game_mode
    {
      get { return _game_mode; }
      set { _game_mode = value; }
    }
    private int _game_winner = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"game_winner", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int game_winner
    {
      get { return _game_winner; }
      set { _game_winner = value; }
    }
    private readonly global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CPlayerInfo> _player_info = new global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CPlayerInfo>();
    [global::ProtoBuf.ProtoMember(4, Name=@"player_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CPlayerInfo> player_info
    {
      get { return _player_info; }
    }
  
    private uint _leagueid = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"leagueid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint leagueid
    {
      get { return _leagueid; }
      set { _leagueid = value; }
    }
    private readonly global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CHeroSelectEvent> _picks_bans = new global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CHeroSelectEvent>();
    [global::ProtoBuf.ProtoMember(6, Name=@"picks_bans", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CHeroSelectEvent> picks_bans
    {
      get { return _picks_bans; }
    }
  
    private uint _radiant_team_id = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"radiant_team_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint radiant_team_id
    {
      get { return _radiant_team_id; }
      set { _radiant_team_id = value; }
    }
    private uint _dire_team_id = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"dire_team_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dire_team_id
    {
      get { return _dire_team_id; }
      set { _dire_team_id = value; }
    }
    private string _radiant_team_tag = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"radiant_team_tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string radiant_team_tag
    {
      get { return _radiant_team_tag; }
      set { _radiant_team_tag = value; }
    }
    private string _dire_team_tag = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"dire_team_tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string dire_team_tag
    {
      get { return _dire_team_tag; }
      set { _dire_team_tag = value; }
    }
    private uint _end_time = default(uint);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"end_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint end_time
    {
      get { return _end_time; }
      set { _end_time = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPlayerInfo")]
  public partial class CPlayerInfo : global::ProtoBuf.IExtensible
  {
    public CPlayerInfo() {}
    
    private string _hero_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hero_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hero_name
    {
      get { return _hero_name; }
      set { _hero_name = value; }
    }
    private string _player_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"player_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string player_name
    {
      get { return _player_name; }
      set { _player_name = value; }
    }
    private bool _is_fake_client = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"is_fake_client", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_fake_client
    {
      get { return _is_fake_client; }
      set { _is_fake_client = value; }
    }
    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }
    private int _game_team = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"game_team", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int game_team
    {
      get { return _game_team; }
      set { _game_team = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHeroSelectEvent")]
  public partial class CHeroSelectEvent : global::ProtoBuf.IExtensible
  {
    public CHeroSelectEvent() {}
    
    private bool _is_pick = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"is_pick", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_pick
    {
      get { return _is_pick; }
      set { _is_pick = value; }
    }
    private uint _team = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"team", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint team
    {
      get { return _team; }
      set { _team = value; }
    }
    private uint _hero_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"hero_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint hero_id
    {
      get { return _hero_id; }
      set { _hero_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoFileInfo")]
  public partial class CDemoFileInfo : global::ProtoBuf.IExtensible
  {
    public CDemoFileInfo() {}
    
    private float _playback_time = default(float);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"playback_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float playback_time
    {
      get { return _playback_time; }
      set { _playback_time = value; }
    }
    private int _playback_ticks = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"playback_ticks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int playback_ticks
    {
      get { return _playback_ticks; }
      set { _playback_ticks = value; }
    }
    private int _playback_frames = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"playback_frames", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int playback_frames
    {
      get { return _playback_frames; }
      set { _playback_frames = value; }
    }
    private CGameInfo _game_info = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"game_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CGameInfo game_info
    {
      get { return _game_info; }
      set { _game_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoPacket")]
  public partial class CDemoPacket : global::ProtoBuf.IExtensible
  {
    public CDemoPacket() {}
    
    private int _sequence_in = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sequence_in", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sequence_in
    {
      get { return _sequence_in; }
      set { _sequence_in = value; }
    }
    private int _sequence_out_ack = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sequence_out_ack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sequence_out_ack
    {
      get { return _sequence_out_ack; }
      set { _sequence_out_ack = value; }
    }
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoFullPacket")]
  public partial class CDemoFullPacket : global::ProtoBuf.IExtensible
  {
    public CDemoFullPacket() {}
    
    private CDemoStringTables _string_table = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"string_table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDemoStringTables string_table
    {
      get { return _string_table; }
      set { _string_table = value; }
    }
    private CDemoPacket _packet = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"packet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDemoPacket packet
    {
      get { return _packet; }
      set { _packet = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoSaveGame")]
  public partial class CDemoSaveGame : global::ProtoBuf.IExtensible
  {
    public CDemoSaveGame() {}
    
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private ulong _steam_id = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"steam_id", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steam_id
    {
      get { return _steam_id; }
      set { _steam_id = value; }
    }
    private ulong _signature = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"signature", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong signature
    {
      get { return _signature; }
      set { _signature = value; }
    }
    private int _version = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int version
    {
      get { return _version; }
      set { _version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoSyncTick")]
  public partial class CDemoSyncTick : global::ProtoBuf.IExtensible
  {
    public CDemoSyncTick() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoConsoleCmd")]
  public partial class CDemoConsoleCmd : global::ProtoBuf.IExtensible
  {
    public CDemoConsoleCmd() {}
    
    private string _cmdstring = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cmdstring", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cmdstring
    {
      get { return _cmdstring; }
      set { _cmdstring = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoSendTables")]
  public partial class CDemoSendTables : global::ProtoBuf.IExtensible
  {
    public CDemoSendTables() {}
    
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoClassInfo")]
  public partial class CDemoClassInfo : global::ProtoBuf.IExtensible
  {
    public CDemoClassInfo() {}
    
    private readonly global::System.Collections.Generic.List<CDemoClassInfo.class_t> _classes = new global::System.Collections.Generic.List<CDemoClassInfo.class_t>();
    [global::ProtoBuf.ProtoMember(1, Name=@"classes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDemoClassInfo.class_t> classes
    {
      get { return _classes; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"class_t")]
  public partial class class_t : global::ProtoBuf.IExtensible
  {
    public class_t() {}
    
    private int _class_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"class_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int class_id
    {
      get { return _class_id; }
      set { _class_id = value; }
    }
    private string _network_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"network_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string network_name
    {
      get { return _network_name; }
      set { _network_name = value; }
    }
    private string _table_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"table_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string table_name
    {
      get { return _table_name; }
      set { _table_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoCustomData")]
  public partial class CDemoCustomData : global::ProtoBuf.IExtensible
  {
    public CDemoCustomData() {}
    
    private int _callback_index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"callback_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int callback_index
    {
      get { return _callback_index; }
      set { _callback_index = value; }
    }
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoCustomDataCallbacks")]
  public partial class CDemoCustomDataCallbacks : global::ProtoBuf.IExtensible
  {
    public CDemoCustomDataCallbacks() {}
    
    private readonly global::System.Collections.Generic.List<string> _save_id = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"save_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> save_id
    {
      get { return _save_id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoStringTables")]
  public partial class CDemoStringTables : global::ProtoBuf.IExtensible
  {
    public CDemoStringTables() {}
    
    private readonly global::System.Collections.Generic.List<CDemoStringTables.table_t> _tables = new global::System.Collections.Generic.List<CDemoStringTables.table_t>();
    [global::ProtoBuf.ProtoMember(1, Name=@"tables", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDemoStringTables.table_t> tables
    {
      get { return _tables; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"items_t")]
  public partial class items_t : global::ProtoBuf.IExtensible
  {
    public items_t() {}
    
    private string _str = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"str", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string str
    {
      get { return _str; }
      set { _str = value; }
    }
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"table_t")]
  public partial class table_t : global::ProtoBuf.IExtensible
  {
    public table_t() {}
    
    private string _table_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"table_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string table_name
    {
      get { return _table_name; }
      set { _table_name = value; }
    }
    private readonly global::System.Collections.Generic.List<CDemoStringTables.items_t> _items = new global::System.Collections.Generic.List<CDemoStringTables.items_t>();
    [global::ProtoBuf.ProtoMember(2, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDemoStringTables.items_t> items
    {
      get { return _items; }
    }
  
    private readonly global::System.Collections.Generic.List<CDemoStringTables.items_t> _items_clientside = new global::System.Collections.Generic.List<CDemoStringTables.items_t>();
    [global::ProtoBuf.ProtoMember(3, Name=@"items_clientside", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDemoStringTables.items_t> items_clientside
    {
      get { return _items_clientside; }
    }
  
    private int _table_flags = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"table_flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int table_flags
    {
      get { return _table_flags; }
      set { _table_flags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoStop")]
  public partial class CDemoStop : global::ProtoBuf.IExtensible
  {
    public CDemoStop() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDemoUserCmd")]
  public partial class CDemoUserCmd : global::ProtoBuf.IExtensible
  {
    public CDemoUserCmd() {}
    
    private int _cmd_number = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cmd_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cmd_number
    {
      get { return _cmd_number; }
      set { _cmd_number = value; }
    }
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_LocationPing")]
  public partial class CDOTAMsg_LocationPing : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_LocationPing() {}
    
    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }
    private int _y = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }
    private int _target = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"target", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int target
    {
      get { return _target; }
      set { _target = value; }
    }
    private bool _direct_ping = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"direct_ping", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool direct_ping
    {
      get { return _direct_ping; }
      set { _direct_ping = value; }
    }
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_ItemAlert")]
  public partial class CDOTAMsg_ItemAlert : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_ItemAlert() {}
    
    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }
    private int _y = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }
    private int _itemid = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_MapLine")]
  public partial class CDOTAMsg_MapLine : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_MapLine() {}
    
    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }
    private int _y = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }
    private bool _initial = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"initial", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool initial
    {
      get { return _initial; }
      set { _initial = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_WorldLine")]
  public partial class CDOTAMsg_WorldLine : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_WorldLine() {}
    
    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }
    private int _y = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }
    private int _z = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int z
    {
      get { return _z; }
      set { _z = value; }
    }
    private bool _initial = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"initial", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool initial
    {
      get { return _initial; }
      set { _initial = value; }
    }
    private bool _end = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"end", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool end
    {
      get { return _end; }
      set { _end = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_SendStatPopup")]
  public partial class CDOTAMsg_SendStatPopup : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_SendStatPopup() {}
    
    private EDOTAStatPopupTypes _style = EDOTAStatPopupTypes.k_EDOTA_SPT_Textline;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"style", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(EDOTAStatPopupTypes.k_EDOTA_SPT_Textline)]
    public EDOTAStatPopupTypes style
    {
      get { return _style; }
      set { _style = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _stat_strings = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(2, Name=@"stat_strings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> stat_strings
    {
      get { return _stat_strings; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _stat_images = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"stat_images", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> stat_images
    {
      get { return _stat_images; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_CoachHUDPing")]
  public partial class CDOTAMsg_CoachHUDPing : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_CoachHUDPing() {}
    
    private uint _x = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint x
    {
      get { return _x; }
      set { _x = value; }
    }
    private uint _y = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint y
    {
      get { return _y; }
      set { _y = value; }
    }
    private string _tgtpath = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"tgtpath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tgtpath
    {
      get { return _tgtpath; }
      set { _tgtpath = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAModifierBuffTableEntry")]
  public partial class CDOTAModifierBuffTableEntry : global::ProtoBuf.IExtensible
  {
    public CDOTAModifierBuffTableEntry() {}
    
    private DOTA_MODIFIER_ENTRY_TYPE _entry_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"entry_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public DOTA_MODIFIER_ENTRY_TYPE entry_type
    {
      get { return _entry_type; }
      set { _entry_type = value; }
    }
    private int _parent;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"parent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int parent
    {
      get { return _parent; }
      set { _parent = value; }
    }
    private int _index;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private int _serial_num;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"serial_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int serial_num
    {
      get { return _serial_num; }
      set { _serial_num = value; }
    }
    private int _modifier_class = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"modifier_class", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int modifier_class
    {
      get { return _modifier_class; }
      set { _modifier_class = value; }
    }
    private int _ability_level = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ability_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ability_level
    {
      get { return _ability_level; }
      set { _ability_level = value; }
    }
    private int _stack_count = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"stack_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int stack_count
    {
      get { return _stack_count; }
      set { _stack_count = value; }
    }
    private float _creation_time = default(float);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"creation_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float creation_time
    {
      get { return _creation_time; }
      set { _creation_time = value; }
    }
    private float _duration = (float)-1;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)-1)]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private int _caster = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"caster", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int caster
    {
      get { return _caster; }
      set { _caster = value; }
    }
    private int _ability = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ability
    {
      get { return _ability; }
      set { _ability = value; }
    }
    private int _armor = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"armor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int armor
    {
      get { return _armor; }
      set { _armor = value; }
    }
    private float _fade_time = default(float);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"fade_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float fade_time
    {
      get { return _fade_time; }
      set { _fade_time = value; }
    }
    private bool _subtle = default(bool);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"subtle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool subtle
    {
      get { return _subtle; }
      set { _subtle = value; }
    }
    private float _channel_time = default(float);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"channel_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float channel_time
    {
      get { return _channel_time; }
      set { _channel_time = value; }
    }
    private CMsgVector _v_start = null;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"v_start", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector v_start
    {
      get { return _v_start; }
      set { _v_start = value; }
    }
    private CMsgVector _v_end = null;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"v_end", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector v_end
    {
      get { return _v_end; }
      set { _v_end = value; }
    }
    private string _portal_loop_appear = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"portal_loop_appear", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string portal_loop_appear
    {
      get { return _portal_loop_appear; }
      set { _portal_loop_appear = value; }
    }
    private string _portal_loop_disappear = "";
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"portal_loop_disappear", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string portal_loop_disappear
    {
      get { return _portal_loop_disappear; }
      set { _portal_loop_disappear = value; }
    }
    private string _hero_loop_appear = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"hero_loop_appear", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hero_loop_appear
    {
      get { return _hero_loop_appear; }
      set { _hero_loop_appear = value; }
    }
    private string _hero_loop_disappear = "";
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"hero_loop_disappear", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hero_loop_disappear
    {
      get { return _hero_loop_disappear; }
      set { _hero_loop_disappear = value; }
    }
    private int _movement_speed = default(int);
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"movement_speed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int movement_speed
    {
      get { return _movement_speed; }
      set { _movement_speed = value; }
    }
    private bool _aura = default(bool);
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"aura", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool aura
    {
      get { return _aura; }
      set { _aura = value; }
    }
    private int _activity = default(int);
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int activity
    {
      get { return _activity; }
      set { _activity = value; }
    }
    private int _damage = default(int);
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int damage
    {
      get { return _damage; }
      set { _damage = value; }
    }
    private int _range = default(int);
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"range", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int range
    {
      get { return _range; }
      set { _range = value; }
    }
    private int _dd_modifier_index = default(int);
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"dd_modifier_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int dd_modifier_index
    {
      get { return _dd_modifier_index; }
      set { _dd_modifier_index = value; }
    }
    private int _dd_ability_index = default(int);
    [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"dd_ability_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int dd_ability_index
    {
      get { return _dd_ability_index; }
      set { _dd_ability_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_AIDebugLine")]
  public partial class CDOTAUserMsg_AIDebugLine : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_AIDebugLine() {}
    
    private string _message = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string message
    {
      get { return _message; }
      set { _message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_Ping")]
  public partial class CDOTAUserMsg_Ping : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_Ping() {}
    
    private string _message = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string message
    {
      get { return _message; }
      set { _message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_SwapVerify")]
  public partial class CDOTAUserMsg_SwapVerify : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_SwapVerify() {}
    
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ChatEvent")]
  public partial class CDOTAUserMsg_ChatEvent : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ChatEvent() {}
    
    private DOTA_CHAT_MESSAGE _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public DOTA_CHAT_MESSAGE type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _value = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint value
    {
      get { return _value; }
      set { _value = value; }
    }
    private int _playerid_1 = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"playerid_1", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int playerid_1
    {
      get { return _playerid_1; }
      set { _playerid_1 = value; }
    }
    private int _playerid_2 = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"playerid_2", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int playerid_2
    {
      get { return _playerid_2; }
      set { _playerid_2 = value; }
    }
    private int _playerid_3 = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"playerid_3", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int playerid_3
    {
      get { return _playerid_3; }
      set { _playerid_3 = value; }
    }
    private int _playerid_4 = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"playerid_4", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int playerid_4
    {
      get { return _playerid_4; }
      set { _playerid_4 = value; }
    }
    private int _playerid_5 = (int)-1;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"playerid_5", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int playerid_5
    {
      get { return _playerid_5; }
      set { _playerid_5 = value; }
    }
    private int _playerid_6 = (int)-1;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"playerid_6", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int playerid_6
    {
      get { return _playerid_6; }
      set { _playerid_6 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_CombatLogData")]
  public partial class CDOTAUserMsg_CombatLogData : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_CombatLogData() {}
    
    private DOTA_COMBATLOG_TYPES _type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_DAMAGE;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_DAMAGE)]
    public DOTA_COMBATLOG_TYPES type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _target_name = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"target_name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint target_name
    {
      get { return _target_name; }
      set { _target_name = value; }
    }
    private uint _attacker_name = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"attacker_name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint attacker_name
    {
      get { return _attacker_name; }
      set { _attacker_name = value; }
    }
    private bool _attacker_illusion = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"attacker_illusion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool attacker_illusion
    {
      get { return _attacker_illusion; }
      set { _attacker_illusion = value; }
    }
    private bool _target_illusion = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"target_illusion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool target_illusion
    {
      get { return _target_illusion; }
      set { _target_illusion = value; }
    }
    private uint _inflictor_name = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"inflictor_name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint inflictor_name
    {
      get { return _inflictor_name; }
      set { _inflictor_name = value; }
    }
    private int _value = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value
    {
      get { return _value; }
      set { _value = value; }
    }
    private int _health = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"health", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int health
    {
      get { return _health; }
      set { _health = value; }
    }
    private float _time = default(float);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float time
    {
      get { return _time; }
      set { _time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_CombatLogShowDeath")]
  public partial class CDOTAUserMsg_CombatLogShowDeath : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_CombatLogShowDeath() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_BotChat")]
  public partial class CDOTAUserMsg_BotChat : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_BotChat() {}
    
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private string _format = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"format", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string format
    {
      get { return _format; }
      set { _format = value; }
    }
    private string _message = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string message
    {
      get { return _message; }
      set { _message = value; }
    }
    private string _target = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"target", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string target
    {
      get { return _target; }
      set { _target = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_CombatHeroPositions")]
  public partial class CDOTAUserMsg_CombatHeroPositions : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_CombatHeroPositions() {}
    
    private uint _index = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint index
    {
      get { return _index; }
      set { _index = value; }
    }
    private int _time = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int time
    {
      get { return _time; }
      set { _time = value; }
    }
    private CMsgVector2D _world_pos = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"world_pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector2D world_pos
    {
      get { return _world_pos; }
      set { _world_pos = value; }
    }
    private int _health = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"health", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int health
    {
      get { return _health; }
      set { _health = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_MiniKillCamInfo")]
  public partial class CDOTAUserMsg_MiniKillCamInfo : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_MiniKillCamInfo() {}
    
    private readonly global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker> _attackers = new global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker>();
    [global::ProtoBuf.ProtoMember(1, Name=@"attackers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker> attackers
    {
      get { return _attackers; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Attacker")]
  public partial class Attacker : global::ProtoBuf.IExtensible
  {
    public Attacker() {}
    
    private uint _attacker = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"attacker", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint attacker
    {
      get { return _attacker; }
      set { _attacker = value; }
    }
    private int _total_damage = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"total_damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int total_damage
    {
      get { return _total_damage; }
      set { _total_damage = value; }
    }
    private readonly global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker.Ability> _abilities = new global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker.Ability>();
    [global::ProtoBuf.ProtoMember(3, Name=@"abilities", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker.Ability> abilities
    {
      get { return _abilities; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Ability")]
  public partial class Ability : global::ProtoBuf.IExtensible
  {
    public Ability() {}
    
    private uint _ability = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ability
    {
      get { return _ability; }
      set { _ability = value; }
    }
    private int _damage = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int damage
    {
      get { return _damage; }
      set { _damage = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_GlobalLightColor")]
  public partial class CDOTAUserMsg_GlobalLightColor : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_GlobalLightColor() {}
    
    private uint _color = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint color
    {
      get { return _color; }
      set { _color = value; }
    }
    private float _duration = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_GlobalLightDirection")]
  public partial class CDOTAUserMsg_GlobalLightDirection : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_GlobalLightDirection() {}
    
    private CMsgVector _direction = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"direction", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector direction
    {
      get { return _direction; }
      set { _direction = value; }
    }
    private float _duration = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_LocationPing")]
  public partial class CDOTAUserMsg_LocationPing : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_LocationPing() {}
    
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private CDOTAMsg_LocationPing _location_ping = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"location_ping", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAMsg_LocationPing location_ping
    {
      get { return _location_ping; }
      set { _location_ping = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ItemAlert")]
  public partial class CDOTAUserMsg_ItemAlert : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ItemAlert() {}
    
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private CDOTAMsg_ItemAlert _item_alert = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"item_alert", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAMsg_ItemAlert item_alert
    {
      get { return _item_alert; }
      set { _item_alert = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_WillPurchaseAlert")]
  public partial class CDOTAUserMsg_WillPurchaseAlert : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_WillPurchaseAlert() {}
    
    private int _itemid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private int _player_id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_CourierKilledAlert")]
  public partial class CDOTAUserMsg_CourierKilledAlert : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_CourierKilledAlert() {}
    
    private uint _team = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"team", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint team
    {
      get { return _team; }
      set { _team = value; }
    }
    private uint _gold_value = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gold_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint gold_value
    {
      get { return _gold_value; }
      set { _gold_value = value; }
    }
    private int _entity_handle = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_handle
    {
      get { return _entity_handle; }
      set { _entity_handle = value; }
    }
    private int _timestamp = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_MinimapEvent")]
  public partial class CDOTAUserMsg_MinimapEvent : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_MinimapEvent() {}
    
    private int _event_type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"event_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int event_type
    {
      get { return _event_type; }
      set { _event_type = value; }
    }
    private int _entity_handle = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_handle
    {
      get { return _entity_handle; }
      set { _entity_handle = value; }
    }
    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }
    private int _y = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }
    private int _duration = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_MapLine")]
  public partial class CDOTAUserMsg_MapLine : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_MapLine() {}
    
    private int _player_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private CDOTAMsg_MapLine _mapline = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mapline", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAMsg_MapLine mapline
    {
      get { return _mapline; }
      set { _mapline = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_MinimapDebugPoint")]
  public partial class CDOTAUserMsg_MinimapDebugPoint : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_MinimapDebugPoint() {}
    
    private CMsgVector _location = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector location
    {
      get { return _location; }
      set { _location = value; }
    }
    private uint _color = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint color
    {
      get { return _color; }
      set { _color = value; }
    }
    private int _size = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int size
    {
      get { return _size; }
      set { _size = value; }
    }
    private float _duration = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_CreateLinearProjectile")]
  public partial class CDOTAUserMsg_CreateLinearProjectile : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_CreateLinearProjectile() {}
    
    private CMsgVector _origin = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"origin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector origin
    {
      get { return _origin; }
      set { _origin = value; }
    }
    private CMsgVector2D _velocity = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"velocity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector2D velocity
    {
      get { return _velocity; }
      set { _velocity = value; }
    }
    private int _latency = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"latency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int latency
    {
      get { return _latency; }
      set { _latency = value; }
    }
    private int _entindex = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entindex
    {
      get { return _entindex; }
      set { _entindex = value; }
    }
    private int _particle_index = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"particle_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int particle_index
    {
      get { return _particle_index; }
      set { _particle_index = value; }
    }
    private int _handle = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int handle
    {
      get { return _handle; }
      set { _handle = value; }
    }
    private CMsgVector2D _acceleration = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"acceleration", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector2D acceleration
    {
      get { return _acceleration; }
      set { _acceleration = value; }
    }
    private float _max_speed = default(float);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"max_speed", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float max_speed
    {
      get { return _max_speed; }
      set { _max_speed = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_DestroyLinearProjectile")]
  public partial class CDOTAUserMsg_DestroyLinearProjectile : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_DestroyLinearProjectile() {}
    
    private int _handle = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int handle
    {
      get { return _handle; }
      set { _handle = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_DodgeTrackingProjectiles")]
  public partial class CDOTAUserMsg_DodgeTrackingProjectiles : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_DodgeTrackingProjectiles() {}
    
    private int _entindex;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int entindex
    {
      get { return _entindex; }
      set { _entindex = value; }
    }
    private bool _attacks_only = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"attacks_only", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool attacks_only
    {
      get { return _attacks_only; }
      set { _attacks_only = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_SpectatorPlayerClick")]
  public partial class CDOTAUserMsg_SpectatorPlayerClick : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_SpectatorPlayerClick() {}
    
    private int _entindex;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int entindex
    {
      get { return _entindex; }
      set { _entindex = value; }
    }
    private int _order_type = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"order_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int order_type
    {
      get { return _order_type; }
      set { _order_type = value; }
    }
    private int _target_index = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"target_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int target_index
    {
      get { return _target_index; }
      set { _target_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_NevermoreRequiem")]
  public partial class CDOTAUserMsg_NevermoreRequiem : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_NevermoreRequiem() {}
    
    private int _entity_handle = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_handle
    {
      get { return _entity_handle; }
      set { _entity_handle = value; }
    }
    private int _lines = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"lines", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int lines
    {
      get { return _lines; }
      set { _lines = value; }
    }
    private CMsgVector _origin = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"origin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector origin
    {
      get { return _origin; }
      set { _origin = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_InvalidCommand")]
  public partial class CDOTAUserMsg_InvalidCommand : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_InvalidCommand() {}
    
    private string _message = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string message
    {
      get { return _message; }
      set { _message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_HudError")]
  public partial class CDOTAUserMsg_HudError : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_HudError() {}
    
    private int _order_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"order_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int order_id
    {
      get { return _order_id; }
      set { _order_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_SharedCooldown")]
  public partial class CDOTAUserMsg_SharedCooldown : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_SharedCooldown() {}
    
    private int _entindex = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entindex
    {
      get { return _entindex; }
      set { _entindex = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private float _cooldown = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"cooldown", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float cooldown
    {
      get { return _cooldown; }
      set { _cooldown = value; }
    }
    private int _name_index = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"name_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int name_index
    {
      get { return _name_index; }
      set { _name_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_SetNextAutobuyItem")]
  public partial class CDOTAUserMsg_SetNextAutobuyItem : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_SetNextAutobuyItem() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_HalloweenDrops")]
  public partial class CDOTAUserMsg_HalloweenDrops : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_HalloweenDrops() {}
    
    private readonly global::System.Collections.Generic.List<uint> _item_defs = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"item_defs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> item_defs
    {
      get { return _item_defs; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _player_ids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"player_ids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> player_ids
    {
      get { return _player_ids; }
    }
  
    private uint _prize_list = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"prize_list", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint prize_list
    {
      get { return _prize_list; }
      set { _prize_list = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAResponseQuerySerialized")]
  public partial class CDOTAResponseQuerySerialized : global::ProtoBuf.IExtensible
  {
    public CDOTAResponseQuerySerialized() {}
    
    private readonly global::System.Collections.Generic.List<CDOTAResponseQuerySerialized.Fact> _facts = new global::System.Collections.Generic.List<CDOTAResponseQuerySerialized.Fact>();
    [global::ProtoBuf.ProtoMember(1, Name=@"facts", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDOTAResponseQuerySerialized.Fact> facts
    {
      get { return _facts; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Fact")]
  public partial class Fact : global::ProtoBuf.IExtensible
  {
    public Fact() {}
    
    private int _key;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int key
    {
      get { return _key; }
      set { _key = value; }
    }
    private CDOTAResponseQuerySerialized.Fact.ValueType _valtype;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"valtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public CDOTAResponseQuerySerialized.Fact.ValueType valtype
    {
      get { return _valtype; }
      set { _valtype = value; }
    }
    private float _val_numeric = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"val_numeric", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float val_numeric
    {
      get { return _val_numeric; }
      set { _val_numeric = value; }
    }
    private string _val_string = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"val_string", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string val_string
    {
      get { return _val_string; }
      set { _val_string = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ValueType")]
    public enum ValueType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NUMERIC", Value=1)]
      NUMERIC = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STRING", Value=2)]
      STRING = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTASpeechMatchOnClient")]
  public partial class CDOTASpeechMatchOnClient : global::ProtoBuf.IExtensible
  {
    public CDOTASpeechMatchOnClient() {}
    
    private int _concept = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"concept", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int concept
    {
      get { return _concept; }
      set { _concept = value; }
    }
    private int _recipient_type = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"recipient_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int recipient_type
    {
      get { return _recipient_type; }
      set { _recipient_type = value; }
    }
    private CDOTAResponseQuerySerialized _responsequery = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"responsequery", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAResponseQuerySerialized responsequery
    {
      get { return _responsequery; }
      set { _responsequery = value; }
    }
    private int _randomseed = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"randomseed", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int randomseed
    {
      get { return _randomseed; }
      set { _randomseed = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_UnitEvent")]
  public partial class CDOTAUserMsg_UnitEvent : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_UnitEvent() {}
    
    private EDotaEntityMessages _msg_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"msg_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public EDotaEntityMessages msg_type
    {
      get { return _msg_type; }
      set { _msg_type = value; }
    }
    private int _entity_index;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"entity_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int entity_index
    {
      get { return _entity_index; }
      set { _entity_index = value; }
    }
    private CDOTAUserMsg_UnitEvent.Speech _speech = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"speech", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_UnitEvent.Speech speech
    {
      get { return _speech; }
      set { _speech = value; }
    }
    private CDOTAUserMsg_UnitEvent.SpeechMute _speech_mute = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"speech_mute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_UnitEvent.SpeechMute speech_mute
    {
      get { return _speech_mute; }
      set { _speech_mute = value; }
    }
    private CDOTAUserMsg_UnitEvent.AddGesture _add_gesture = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"add_gesture", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_UnitEvent.AddGesture add_gesture
    {
      get { return _add_gesture; }
      set { _add_gesture = value; }
    }
    private CDOTAUserMsg_UnitEvent.RemoveGesture _remove_gesture = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"remove_gesture", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_UnitEvent.RemoveGesture remove_gesture
    {
      get { return _remove_gesture; }
      set { _remove_gesture = value; }
    }
    private CDOTAUserMsg_UnitEvent.BloodImpact _blood_impact = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"blood_impact", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_UnitEvent.BloodImpact blood_impact
    {
      get { return _blood_impact; }
      set { _blood_impact = value; }
    }
    private CDOTAUserMsg_UnitEvent.FadeGesture _fade_gesture = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"fade_gesture", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_UnitEvent.FadeGesture fade_gesture
    {
      get { return _fade_gesture; }
      set { _fade_gesture = value; }
    }
    private CDOTASpeechMatchOnClient _speech_match_on_client = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"speech_match_on_client", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTASpeechMatchOnClient speech_match_on_client
    {
      get { return _speech_match_on_client; }
      set { _speech_match_on_client = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Speech")]
  public partial class Speech : global::ProtoBuf.IExtensible
  {
    public Speech() {}
    
    private int _concept = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"concept", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int concept
    {
      get { return _concept; }
      set { _concept = value; }
    }
    private string _response = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"response", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string response
    {
      get { return _response; }
      set { _response = value; }
    }
    private int _recipient_type = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"recipient_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int recipient_type
    {
      get { return _recipient_type; }
      set { _recipient_type = value; }
    }
    private int _level = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private bool _muteable = (bool)false;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"muteable", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool muteable
    {
      get { return _muteable; }
      set { _muteable = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SpeechMute")]
  public partial class SpeechMute : global::ProtoBuf.IExtensible
  {
    public SpeechMute() {}
    
    private float _delay = (float)0.5;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"delay", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0.5)]
    public float delay
    {
      get { return _delay; }
      set { _delay = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AddGesture")]
  public partial class AddGesture : global::ProtoBuf.IExtensible
  {
    public AddGesture() {}
    
    private Activity _activity = Activity.ACT_INVALID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Activity.ACT_INVALID)]
    public Activity activity
    {
      get { return _activity; }
      set { _activity = value; }
    }
    private int _slot = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"slot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int slot
    {
      get { return _slot; }
      set { _slot = value; }
    }
    private float _fade_in = (float)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"fade_in", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0)]
    public float fade_in
    {
      get { return _fade_in; }
      set { _fade_in = value; }
    }
    private float _fade_out = (float)0.1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"fade_out", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0.1)]
    public float fade_out
    {
      get { return _fade_out; }
      set { _fade_out = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RemoveGesture")]
  public partial class RemoveGesture : global::ProtoBuf.IExtensible
  {
    public RemoveGesture() {}
    
    private Activity _activity = Activity.ACT_INVALID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Activity.ACT_INVALID)]
    public Activity activity
    {
      get { return _activity; }
      set { _activity = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BloodImpact")]
  public partial class BloodImpact : global::ProtoBuf.IExtensible
  {
    public BloodImpact() {}
    
    private int _scale = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"scale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int scale
    {
      get { return _scale; }
      set { _scale = value; }
    }
    private int _x_normal = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"x_normal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x_normal
    {
      get { return _x_normal; }
      set { _x_normal = value; }
    }
    private int _y_normal = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"y_normal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y_normal
    {
      get { return _y_normal; }
      set { _y_normal = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FadeGesture")]
  public partial class FadeGesture : global::ProtoBuf.IExtensible
  {
    public FadeGesture() {}
    
    private Activity _activity = Activity.ACT_INVALID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Activity.ACT_INVALID)]
    public Activity activity
    {
      get { return _activity; }
      set { _activity = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ItemPurchased")]
  public partial class CDOTAUserMsg_ItemPurchased : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ItemPurchased() {}
    
    private int _item_index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"item_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int item_index
    {
      get { return _item_index; }
      set { _item_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ItemFound")]
  public partial class CDOTAUserMsg_ItemFound : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ItemFound() {}
    
    private int _player = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player
    {
      get { return _player; }
      set { _player = value; }
    }
    private int _quality = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int quality
    {
      get { return _quality; }
      set { _quality = value; }
    }
    private int _rarity = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rarity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rarity
    {
      get { return _rarity; }
      set { _rarity = value; }
    }
    private int _method = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"method", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int method
    {
      get { return _method; }
      set { _method = value; }
    }
    private int _itemdef = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"itemdef", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int itemdef
    {
      get { return _itemdef; }
      set { _itemdef = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ParticleManager")]
  public partial class CDOTAUserMsg_ParticleManager : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ParticleManager() {}
    
    private DOTA_PARTICLE_MESSAGE _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public DOTA_PARTICLE_MESSAGE type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _index;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint index
    {
      get { return _index; }
      set { _index = value; }
    }
    private CDOTAUserMsg_ParticleManager.ReleaseParticleIndex _release_particle_index = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"release_particle_index", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.ReleaseParticleIndex release_particle_index
    {
      get { return _release_particle_index; }
      set { _release_particle_index = value; }
    }
    private CDOTAUserMsg_ParticleManager.CreateParticle _create_particle = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"create_particle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.CreateParticle create_particle
    {
      get { return _create_particle; }
      set { _create_particle = value; }
    }
    private CDOTAUserMsg_ParticleManager.DestroyParticle _destroy_particle = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"destroy_particle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.DestroyParticle destroy_particle
    {
      get { return _destroy_particle; }
      set { _destroy_particle = value; }
    }
    private CDOTAUserMsg_ParticleManager.DestroyParticleInvolving _destroy_particle_involving = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"destroy_particle_involving", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.DestroyParticleInvolving destroy_particle_involving
    {
      get { return _destroy_particle_involving; }
      set { _destroy_particle_involving = value; }
    }
    private CDOTAUserMsg_ParticleManager.UpdateParticle _update_particle = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"update_particle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.UpdateParticle update_particle
    {
      get { return _update_particle; }
      set { _update_particle = value; }
    }
    private CDOTAUserMsg_ParticleManager.UpdateParticleFwd _update_particle_fwd = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"update_particle_fwd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.UpdateParticleFwd update_particle_fwd
    {
      get { return _update_particle_fwd; }
      set { _update_particle_fwd = value; }
    }
    private CDOTAUserMsg_ParticleManager.UpdateParticleOrient _update_particle_orient = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"update_particle_orient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.UpdateParticleOrient update_particle_orient
    {
      get { return _update_particle_orient; }
      set { _update_particle_orient = value; }
    }
    private CDOTAUserMsg_ParticleManager.UpdateParticleFallback _update_particle_fallback = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"update_particle_fallback", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.UpdateParticleFallback update_particle_fallback
    {
      get { return _update_particle_fallback; }
      set { _update_particle_fallback = value; }
    }
    private CDOTAUserMsg_ParticleManager.UpdateParticleOffset _update_particle_offset = null;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"update_particle_offset", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.UpdateParticleOffset update_particle_offset
    {
      get { return _update_particle_offset; }
      set { _update_particle_offset = value; }
    }
    private CDOTAUserMsg_ParticleManager.UpdateParticleEnt _update_particle_ent = null;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"update_particle_ent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.UpdateParticleEnt update_particle_ent
    {
      get { return _update_particle_ent; }
      set { _update_particle_ent = value; }
    }
    private CDOTAUserMsg_ParticleManager.UpdateParticleShouldDraw _update_particle_should_draw = null;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"update_particle_should_draw", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.UpdateParticleShouldDraw update_particle_should_draw
    {
      get { return _update_particle_should_draw; }
      set { _update_particle_should_draw = value; }
    }
    private CDOTAUserMsg_ParticleManager.UpdateParticleSetFrozen _update_particle_set_frozen = null;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"update_particle_set_frozen", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAUserMsg_ParticleManager.UpdateParticleSetFrozen update_particle_set_frozen
    {
      get { return _update_particle_set_frozen; }
      set { _update_particle_set_frozen = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReleaseParticleIndex")]
  public partial class ReleaseParticleIndex : global::ProtoBuf.IExtensible
  {
    public ReleaseParticleIndex() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateParticle")]
  public partial class CreateParticle : global::ProtoBuf.IExtensible
  {
    public CreateParticle() {}
    
    private int _particle_name_index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"particle_name_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int particle_name_index
    {
      get { return _particle_name_index; }
      set { _particle_name_index = value; }
    }
    private int _attach_type = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"attach_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int attach_type
    {
      get { return _attach_type; }
      set { _attach_type = value; }
    }
    private int _entity_handle = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_handle
    {
      get { return _entity_handle; }
      set { _entity_handle = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DestroyParticle")]
  public partial class DestroyParticle : global::ProtoBuf.IExtensible
  {
    public DestroyParticle() {}
    
    private bool _destroy_immediately = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"destroy_immediately", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool destroy_immediately
    {
      get { return _destroy_immediately; }
      set { _destroy_immediately = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DestroyParticleInvolving")]
  public partial class DestroyParticleInvolving : global::ProtoBuf.IExtensible
  {
    public DestroyParticleInvolving() {}
    
    private bool _destroy_immediately = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"destroy_immediately", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool destroy_immediately
    {
      get { return _destroy_immediately; }
      set { _destroy_immediately = value; }
    }
    private int _entity_handle = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_handle
    {
      get { return _entity_handle; }
      set { _entity_handle = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateParticle")]
  public partial class UpdateParticle : global::ProtoBuf.IExtensible
  {
    public UpdateParticle() {}
    
    private int _control_point = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int control_point
    {
      get { return _control_point; }
      set { _control_point = value; }
    }
    private CMsgVector _position = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector position
    {
      get { return _position; }
      set { _position = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateParticleFwd")]
  public partial class UpdateParticleFwd : global::ProtoBuf.IExtensible
  {
    public UpdateParticleFwd() {}
    
    private int _control_point = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int control_point
    {
      get { return _control_point; }
      set { _control_point = value; }
    }
    private CMsgVector _forward = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"forward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector forward
    {
      get { return _forward; }
      set { _forward = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateParticleOrient")]
  public partial class UpdateParticleOrient : global::ProtoBuf.IExtensible
  {
    public UpdateParticleOrient() {}
    
    private int _control_point = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int control_point
    {
      get { return _control_point; }
      set { _control_point = value; }
    }
    private CMsgVector _forward = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"forward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector forward
    {
      get { return _forward; }
      set { _forward = value; }
    }
    private CMsgVector _right = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"right", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector right
    {
      get { return _right; }
      set { _right = value; }
    }
    private CMsgVector _up = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"up", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector up
    {
      get { return _up; }
      set { _up = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateParticleFallback")]
  public partial class UpdateParticleFallback : global::ProtoBuf.IExtensible
  {
    public UpdateParticleFallback() {}
    
    private int _control_point = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int control_point
    {
      get { return _control_point; }
      set { _control_point = value; }
    }
    private CMsgVector _position = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector position
    {
      get { return _position; }
      set { _position = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateParticleOffset")]
  public partial class UpdateParticleOffset : global::ProtoBuf.IExtensible
  {
    public UpdateParticleOffset() {}
    
    private int _control_point = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int control_point
    {
      get { return _control_point; }
      set { _control_point = value; }
    }
    private CMsgVector _origin_offset = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"origin_offset", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector origin_offset
    {
      get { return _origin_offset; }
      set { _origin_offset = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateParticleEnt")]
  public partial class UpdateParticleEnt : global::ProtoBuf.IExtensible
  {
    public UpdateParticleEnt() {}
    
    private int _control_point = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int control_point
    {
      get { return _control_point; }
      set { _control_point = value; }
    }
    private int _entity_handle = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_handle
    {
      get { return _entity_handle; }
      set { _entity_handle = value; }
    }
    private int _attach_type = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"attach_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int attach_type
    {
      get { return _attach_type; }
      set { _attach_type = value; }
    }
    private int _attachment = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"attachment", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int attachment
    {
      get { return _attachment; }
      set { _attachment = value; }
    }
    private CMsgVector _fallback_position = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"fallback_position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector fallback_position
    {
      get { return _fallback_position; }
      set { _fallback_position = value; }
    }
    private bool _include_wearables = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"include_wearables", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool include_wearables
    {
      get { return _include_wearables; }
      set { _include_wearables = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateParticleSetFrozen")]
  public partial class UpdateParticleSetFrozen : global::ProtoBuf.IExtensible
  {
    public UpdateParticleSetFrozen() {}
    
    private bool _set_frozen = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"set_frozen", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool set_frozen
    {
      get { return _set_frozen; }
      set { _set_frozen = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateParticleShouldDraw")]
  public partial class UpdateParticleShouldDraw : global::ProtoBuf.IExtensible
  {
    public UpdateParticleShouldDraw() {}
    
    private bool _should_draw = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"should_draw", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool should_draw
    {
      get { return _should_draw; }
      set { _should_draw = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_OverheadEvent")]
  public partial class CDOTAUserMsg_OverheadEvent : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_OverheadEvent() {}
    
    private DOTA_OVERHEAD_ALERT _message_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"message_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public DOTA_OVERHEAD_ALERT message_type
    {
      get { return _message_type; }
      set { _message_type = value; }
    }
    private int _value = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value
    {
      get { return _value; }
      set { _value = value; }
    }
    private int _target_player_entindex = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"target_player_entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int target_player_entindex
    {
      get { return _target_player_entindex; }
      set { _target_player_entindex = value; }
    }
    private int _target_entindex = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"target_entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int target_entindex
    {
      get { return _target_entindex; }
      set { _target_entindex = value; }
    }
    private int _source_player_entindex = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"source_player_entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int source_player_entindex
    {
      get { return _source_player_entindex; }
      set { _source_player_entindex = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_TutorialTipInfo")]
  public partial class CDOTAUserMsg_TutorialTipInfo : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_TutorialTipInfo() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _progress = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int progress
    {
      get { return _progress; }
      set { _progress = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_TutorialFinish")]
  public partial class CDOTAUserMsg_TutorialFinish : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_TutorialFinish() {}
    
    private string _heading = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"heading", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string heading
    {
      get { return _heading; }
      set { _heading = value; }
    }
    private string _emblem = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"emblem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string emblem
    {
      get { return _emblem; }
      set { _emblem = value; }
    }
    private string _body = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"body", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string body
    {
      get { return _body; }
      set { _body = value; }
    }
    private bool _success = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_TutorialMinimapPosition")]
  public partial class CDOTAUserMsg_TutorialMinimapPosition : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_TutorialMinimapPosition() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_TournamentDrop")]
  public partial class CDOTAUserMsg_TournamentDrop : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_TournamentDrop() {}
    
    private string _winner_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"winner_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string winner_name
    {
      get { return _winner_name; }
      set { _winner_name = value; }
    }
    private int _event_type = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"event_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int event_type
    {
      get { return _event_type; }
      set { _event_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_SendGenericToolTip")]
  public partial class CDOTAUserMsg_SendGenericToolTip : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_SendGenericToolTip() {}
    
    private string _title = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string title
    {
      get { return _title; }
      set { _title = value; }
    }
    private string _text = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text
    {
      get { return _text; }
      set { _text = value; }
    }
    private int _entindex = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entindex
    {
      get { return _entindex; }
      set { _entindex = value; }
    }
    private bool _close = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"close", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool close
    {
      get { return _close; }
      set { _close = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_WorldLine")]
  public partial class CDOTAUserMsg_WorldLine : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_WorldLine() {}
    
    private int _player_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private CDOTAMsg_WorldLine _worldline = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"worldline", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAMsg_WorldLine worldline
    {
      get { return _worldline; }
      set { _worldline = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ChatWheel")]
  public partial class CDOTAUserMsg_ChatWheel : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ChatWheel() {}
    
    private EDOTAChatWheelMessage _chat_message = EDOTAChatWheelMessage.k_EDOTA_CW_Ok;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"chat_message", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(EDOTAChatWheelMessage.k_EDOTA_CW_Ok)]
    public EDOTAChatWheelMessage chat_message
    {
      get { return _chat_message; }
      set { _chat_message = value; }
    }
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private uint _account_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint account_id
    {
      get { return _account_id; }
      set { _account_id = value; }
    }
    private uint _param_hero_id = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"param_hero_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint param_hero_id
    {
      get { return _param_hero_id; }
      set { _param_hero_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ReceivedXmasGift")]
  public partial class CDOTAUserMsg_ReceivedXmasGift : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ReceivedXmasGift() {}
    
    private int _player_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private string _item_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"item_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string item_name
    {
      get { return _item_name; }
      set { _item_name = value; }
    }
    private int _inventory_slot = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"inventory_slot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int inventory_slot
    {
      get { return _inventory_slot; }
      set { _inventory_slot = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ShowSurvey")]
  public partial class CDOTAUserMsg_ShowSurvey : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ShowSurvey() {}
    
    private int _survey_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"survey_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int survey_id
    {
      get { return _survey_id; }
      set { _survey_id = value; }
    }
    private uint _match_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint match_id
    {
      get { return _match_id; }
      set { _match_id = value; }
    }
    private string _response_style = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"response_style", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string response_style
    {
      get { return _response_style; }
      set { _response_style = value; }
    }
    private uint _teammate_hero_id = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"teammate_hero_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint teammate_hero_id
    {
      get { return _teammate_hero_id; }
      set { _teammate_hero_id = value; }
    }
    private string _teammate_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"teammate_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string teammate_name
    {
      get { return _teammate_name; }
      set { _teammate_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_UpdateSharedContent")]
  public partial class CDOTAUserMsg_UpdateSharedContent : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_UpdateSharedContent() {}
    
    private int _slot_type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"slot_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int slot_type
    {
      get { return _slot_type; }
      set { _slot_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_TutorialRequestExp")]
  public partial class CDOTAUserMsg_TutorialRequestExp : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_TutorialRequestExp() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_TutorialFade")]
  public partial class CDOTAUserMsg_TutorialFade : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_TutorialFade() {}
    
    private int _tgt_alpha = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tgt_alpha", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int tgt_alpha
    {
      get { return _tgt_alpha; }
      set { _tgt_alpha = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_TutorialPingMinimap")]
  public partial class CDOTAUserMsg_TutorialPingMinimap : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_TutorialPingMinimap() {}
    
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private float _pos_x = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pos_x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float pos_x
    {
      get { return _pos_x; }
      set { _pos_x = value; }
    }
    private float _pos_y = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pos_y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float pos_y
    {
      get { return _pos_y; }
      set { _pos_y = value; }
    }
    private float _pos_z = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"pos_z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float pos_z
    {
      get { return _pos_z; }
      set { _pos_z = value; }
    }
    private int _entity_index = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"entity_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_index
    {
      get { return _entity_index; }
      set { _entity_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTA_UM_GamerulesStateChanged")]
  public partial class CDOTA_UM_GamerulesStateChanged : global::ProtoBuf.IExtensible
  {
    public CDOTA_UM_GamerulesStateChanged() {}
    
    private uint _state = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint state
    {
      get { return _state; }
      set { _state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_AddQuestLogEntry")]
  public partial class CDOTAUserMsg_AddQuestLogEntry : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_AddQuestLogEntry() {}
    
    private string _npc_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"npc_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string npc_name
    {
      get { return _npc_name; }
      set { _npc_name = value; }
    }
    private string _npc_dialog = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"npc_dialog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string npc_dialog
    {
      get { return _npc_dialog; }
      set { _npc_dialog = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_SendStatPopup")]
  public partial class CDOTAUserMsg_SendStatPopup : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_SendStatPopup() {}
    
    private int _player_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private CDOTAMsg_SendStatPopup _statpopup = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"statpopup", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAMsg_SendStatPopup statpopup
    {
      get { return _statpopup; }
      set { _statpopup = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_SendRoshanPopup")]
  public partial class CDOTAUserMsg_SendRoshanPopup : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_SendRoshanPopup() {}
    
    private bool _reclaimed = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"reclaimed", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool reclaimed
    {
      get { return _reclaimed; }
      set { _reclaimed = value; }
    }
    private int _gametime = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gametime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int gametime
    {
      get { return _gametime; }
      set { _gametime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_SendFinalGold")]
  public partial class CDOTAUserMsg_SendFinalGold : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_SendFinalGold() {}
    
    private readonly global::System.Collections.Generic.List<uint> _reliable_gold = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"reliable_gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> reliable_gold
    {
      get { return _reliable_gold; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _unreliable_gold = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"unreliable_gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> unreliable_gold
    {
      get { return _unreliable_gold; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_CustomMsg")]
  public partial class CDOTAUserMsg_CustomMsg : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_CustomMsg() {}
    
    private string _message = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string message
    {
      get { return _message; }
      set { _message = value; }
    }
    private int _player_id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private int _value = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_CoachHUDPing")]
  public partial class CDOTAUserMsg_CoachHUDPing : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_CoachHUDPing() {}
    
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private CDOTAMsg_CoachHUDPing _hud_ping = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"hud_ping", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CDOTAMsg_CoachHUDPing hud_ping
    {
      get { return _hud_ping; }
      set { _hud_ping = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ClientLoadGridNav")]
  public partial class CDOTAUserMsg_ClientLoadGridNav : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ClientLoadGridNav() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_AbilityPing")]
  public partial class CDOTAUserMsg_AbilityPing : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_AbilityPing() {}
    
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private uint _ability_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ability_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ability_id
    {
      get { return _ability_id; }
      set { _ability_id = value; }
    }
    private DOTA_ABILITY_PING_TYPE _type = DOTA_ABILITY_PING_TYPE.ABILITY_PING_READY;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(DOTA_ABILITY_PING_TYPE.ABILITY_PING_READY)]
    public DOTA_ABILITY_PING_TYPE type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _cooldown_seconds = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"cooldown_seconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cooldown_seconds
    {
      get { return _cooldown_seconds; }
      set { _cooldown_seconds = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_ShowGenericPopup")]
  public partial class CDOTAUserMsg_ShowGenericPopup : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_ShowGenericPopup() {}
    
    private string _header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string header
    {
      get { return _header; }
      set { _header = value; }
    }
    private string _body;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"body", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string body
    {
      get { return _body; }
      set { _body = value; }
    }
    private string _param1 = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"param1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string param1
    {
      get { return _param1; }
      set { _param1 = value; }
    }
    private string _param2 = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"param2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string param2
    {
      get { return _param2; }
      set { _param2 = value; }
    }
    private bool _tint_screen = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"tint_screen", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool tint_screen
    {
      get { return _tint_screen; }
      set { _tint_screen = value; }
    }
    private bool _show_no_other_dialogs = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"show_no_other_dialogs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool show_no_other_dialogs
    {
      get { return _show_no_other_dialogs; }
      set { _show_no_other_dialogs = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_VoteStart")]
  public partial class CDOTAUserMsg_VoteStart : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_VoteStart() {}
    
    private string _title = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string title
    {
      get { return _title; }
      set { _title = value; }
    }
    private float _duration = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private int _choice_count = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"choice_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int choice_count
    {
      get { return _choice_count; }
      set { _choice_count = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _choices = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(4, Name=@"choices", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> choices
    {
      get { return _choices; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_VoteUpdate")]
  public partial class CDOTAUserMsg_VoteUpdate : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_VoteUpdate() {}
    
    private readonly global::System.Collections.Generic.List<int> _choice_counts = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"choice_counts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> choice_counts
    {
      get { return _choice_counts; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_VoteEnd")]
  public partial class CDOTAUserMsg_VoteEnd : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_VoteEnd() {}
    
    private int _selected_choice = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"selected_choice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int selected_choice
    {
      get { return _selected_choice; }
      set { _selected_choice = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_BoosterStatePlayer")]
  public partial class CDOTAUserMsg_BoosterStatePlayer : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_BoosterStatePlayer() {}
    
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private float _bonus = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bonus", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float bonus
    {
      get { return _bonus; }
      set { _bonus = value; }
    }
    private float _event_bonus = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"event_bonus", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float event_bonus
    {
      get { return _event_bonus; }
      set { _event_bonus = value; }
    }
    private uint _bonus_item_id = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"bonus_item_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint bonus_item_id
    {
      get { return _bonus_item_id; }
      set { _bonus_item_id = value; }
    }
    private uint _event_bonus_item_id = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"event_bonus_item_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint event_bonus_item_id
    {
      get { return _event_bonus_item_id; }
      set { _event_bonus_item_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_BoosterState")]
  public partial class CDOTAUserMsg_BoosterState : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_BoosterState() {}
    
    private readonly global::System.Collections.Generic.List<CDOTAUserMsg_BoosterStatePlayer> _boosted_players = new global::System.Collections.Generic.List<CDOTAUserMsg_BoosterStatePlayer>();
    [global::ProtoBuf.ProtoMember(1, Name=@"boosted_players", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CDOTAUserMsg_BoosterStatePlayer> boosted_players
    {
      get { return _boosted_players; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_PlayerMMR")]
  public partial class CDOTAUserMsg_PlayerMMR : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_PlayerMMR() {}
    
    private readonly global::System.Collections.Generic.List<int> _mmr = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"mmr", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> mmr
    {
      get { return _mmr; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAUserMsg_AbilitySteal")]
  public partial class CDOTAUserMsg_AbilitySteal : global::ProtoBuf.IExtensible
  {
    public CDOTAUserMsg_AbilitySteal() {}
    
    private uint _player_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private uint _ability_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ability_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ability_id
    {
      get { return _ability_id; }
      set { _ability_id = value; }
    }
    private uint _ability_level = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ability_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ability_level
    {
      get { return _ability_level; }
      set { _ability_level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsg_CVars")]
  public partial class CMsg_CVars : global::ProtoBuf.IExtensible
  {
    public CMsg_CVars() {}
    
    private readonly global::System.Collections.Generic.List<CMsg_CVars.CVar> _cvars = new global::System.Collections.Generic.List<CMsg_CVars.CVar>();
    [global::ProtoBuf.ProtoMember(1, Name=@"cvars", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsg_CVars.CVar> cvars
    {
      get { return _cvars; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CVar")]
  public partial class CVar : global::ProtoBuf.IExtensible
  {
    public CVar() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _value = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNETMsg_NOP")]
  public partial class CNETMsg_NOP : global::ProtoBuf.IExtensible
  {
    public CNETMsg_NOP() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNETMsg_Disconnect")]
  public partial class CNETMsg_Disconnect : global::ProtoBuf.IExtensible
  {
    public CNETMsg_Disconnect() {}
    
    private ENetworkDisconnectionReason _reason = ENetworkDisconnectionReason.NETWORK_DISCONNECT_INVALID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(ENetworkDisconnectionReason.NETWORK_DISCONNECT_INVALID)]
    public ENetworkDisconnectionReason reason
    {
      get { return _reason; }
      set { _reason = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNETMsg_File")]
  public partial class CNETMsg_File : global::ProtoBuf.IExtensible
  {
    public CNETMsg_File() {}
    
    private int _transfer_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"transfer_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int transfer_id
    {
      get { return _transfer_id; }
      set { _transfer_id = value; }
    }
    private string _file_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"file_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string file_name
    {
      get { return _file_name; }
      set { _file_name = value; }
    }
    private bool _is_replay_demo_file = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"is_replay_demo_file", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_replay_demo_file
    {
      get { return _is_replay_demo_file; }
      set { _is_replay_demo_file = value; }
    }
    private bool _deny = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"deny", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool deny
    {
      get { return _deny; }
      set { _deny = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNETMsg_SplitScreenUser")]
  public partial class CNETMsg_SplitScreenUser : global::ProtoBuf.IExtensible
  {
    public CNETMsg_SplitScreenUser() {}
    
    private int _slot = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"slot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int slot
    {
      get { return _slot; }
      set { _slot = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNETMsg_Tick")]
  public partial class CNETMsg_Tick : global::ProtoBuf.IExtensible
  {
    public CNETMsg_Tick() {}
    
    private uint _tick = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tick", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint tick
    {
      get { return _tick; }
      set { _tick = value; }
    }
    private uint _host_computationtime = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"host_computationtime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint host_computationtime
    {
      get { return _host_computationtime; }
      set { _host_computationtime = value; }
    }
    private uint _host_computationtime_std_deviation = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"host_computationtime_std_deviation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint host_computationtime_std_deviation
    {
      get { return _host_computationtime_std_deviation; }
      set { _host_computationtime_std_deviation = value; }
    }
    private uint _host_framestarttime_std_deviation = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"host_framestarttime_std_deviation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint host_framestarttime_std_deviation
    {
      get { return _host_framestarttime_std_deviation; }
      set { _host_framestarttime_std_deviation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNETMsg_StringCmd")]
  public partial class CNETMsg_StringCmd : global::ProtoBuf.IExtensible
  {
    public CNETMsg_StringCmd() {}
    
    private string _command = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string command
    {
      get { return _command; }
      set { _command = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNETMsg_SetConVar")]
  public partial class CNETMsg_SetConVar : global::ProtoBuf.IExtensible
  {
    public CNETMsg_SetConVar() {}
    
    private CMsg_CVars _convars = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"convars", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsg_CVars convars
    {
      get { return _convars; }
      set { _convars = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNETMsg_SignonState")]
  public partial class CNETMsg_SignonState : global::ProtoBuf.IExtensible
  {
    public CNETMsg_SignonState() {}
    
    private uint _signon_state = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"signon_state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint signon_state
    {
      get { return _signon_state; }
      set { _signon_state = value; }
    }
    private uint _spawn_count = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"spawn_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint spawn_count
    {
      get { return _spawn_count; }
      set { _spawn_count = value; }
    }
    private uint _num_server_players = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"num_server_players", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num_server_players
    {
      get { return _num_server_players; }
      set { _num_server_players = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _players_networkids = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(4, Name=@"players_networkids", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> players_networkids
    {
      get { return _players_networkids; }
    }
  
    private string _map_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"map_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string map_name
    {
      get { return _map_name; }
      set { _map_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_ClientInfo")]
  public partial class CCLCMsg_ClientInfo : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_ClientInfo() {}
    
    private uint _send_table_crc = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"send_table_crc", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint send_table_crc
    {
      get { return _send_table_crc; }
      set { _send_table_crc = value; }
    }
    private uint _server_count = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"server_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_count
    {
      get { return _server_count; }
      set { _server_count = value; }
    }
    private bool _is_hltv = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"is_hltv", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_hltv
    {
      get { return _is_hltv; }
      set { _is_hltv = value; }
    }
    private bool _is_replay = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"is_replay", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_replay
    {
      get { return _is_replay; }
      set { _is_replay = value; }
    }
    private uint _friends_id = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"friends_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint friends_id
    {
      get { return _friends_id; }
      set { _friends_id = value; }
    }
    private string _friends_name = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"friends_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string friends_name
    {
      get { return _friends_name; }
      set { _friends_name = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _custom_files = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"custom_files", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public global::System.Collections.Generic.List<uint> custom_files
    {
      get { return _custom_files; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_Move")]
  public partial class CCLCMsg_Move : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_Move() {}
    
    private uint _num_backup_commands = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"num_backup_commands", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num_backup_commands
    {
      get { return _num_backup_commands; }
      set { _num_backup_commands = value; }
    }
    private uint _num_new_commands = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"num_new_commands", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num_new_commands
    {
      get { return _num_new_commands; }
      set { _num_new_commands = value; }
    }
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_VoiceData")]
  public partial class CCLCMsg_VoiceData : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_VoiceData() {}
    
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private ulong _xuid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"xuid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong xuid
    {
      get { return _xuid; }
      set { _xuid = value; }
    }
    private VoiceDataFormat_t _format = VoiceDataFormat_t.VOICEDATA_FORMAT_STEAM;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"format", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(VoiceDataFormat_t.VOICEDATA_FORMAT_STEAM)]
    public VoiceDataFormat_t format
    {
      get { return _format; }
      set { _format = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_BaselineAck")]
  public partial class CCLCMsg_BaselineAck : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_BaselineAck() {}
    
    private int _baseline_tick = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"baseline_tick", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int baseline_tick
    {
      get { return _baseline_tick; }
      set { _baseline_tick = value; }
    }
    private int _baseline_nr = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"baseline_nr", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int baseline_nr
    {
      get { return _baseline_nr; }
      set { _baseline_nr = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_ListenEvents")]
  public partial class CCLCMsg_ListenEvents : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_ListenEvents() {}
    
    private readonly global::System.Collections.Generic.List<uint> _event_mask = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"event_mask", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public global::System.Collections.Generic.List<uint> event_mask
    {
      get { return _event_mask; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_RespondCvarValue")]
  public partial class CCLCMsg_RespondCvarValue : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_RespondCvarValue() {}
    
    private int _cookie = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cookie", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cookie
    {
      get { return _cookie; }
      set { _cookie = value; }
    }
    private int _status_code = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"status_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int status_code
    {
      get { return _status_code; }
      set { _status_code = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _value = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_FileCRCCheck")]
  public partial class CCLCMsg_FileCRCCheck : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_FileCRCCheck() {}
    
    private int _code_path = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"code_path", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int code_path
    {
      get { return _code_path; }
      set { _code_path = value; }
    }
    private string _path = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string path
    {
      get { return _path; }
      set { _path = value; }
    }
    private int _code_filename = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"code_filename", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int code_filename
    {
      get { return _code_filename; }
      set { _code_filename = value; }
    }
    private string _filename = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filename
    {
      get { return _filename; }
      set { _filename = value; }
    }
    private uint _crc = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"crc", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint crc
    {
      get { return _crc; }
      set { _crc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_LoadingProgress")]
  public partial class CCLCMsg_LoadingProgress : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_LoadingProgress() {}
    
    private int _progress = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int progress
    {
      get { return _progress; }
      set { _progress = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_SplitPlayerConnect")]
  public partial class CCLCMsg_SplitPlayerConnect : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_SplitPlayerConnect() {}
    
    private CMsg_CVars _convars = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"convars", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsg_CVars convars
    {
      get { return _convars; }
      set { _convars = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCLCMsg_ClientMessage")]
  public partial class CCLCMsg_ClientMessage : global::ProtoBuf.IExtensible
  {
    public CCLCMsg_ClientMessage() {}
    
    private int _msg_type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msg_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int msg_type
    {
      get { return _msg_type; }
      set { _msg_type = value; }
    }
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_ServerInfo")]
  public partial class CSVCMsg_ServerInfo : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_ServerInfo() {}
    
    private int _protocol = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"protocol", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int protocol
    {
      get { return _protocol; }
      set { _protocol = value; }
    }
    private int _server_count = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"server_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int server_count
    {
      get { return _server_count; }
      set { _server_count = value; }
    }
    private bool _is_dedicated = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"is_dedicated", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_dedicated
    {
      get { return _is_dedicated; }
      set { _is_dedicated = value; }
    }
    private bool _is_hltv = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"is_hltv", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_hltv
    {
      get { return _is_hltv; }
      set { _is_hltv = value; }
    }
    private bool _is_replay = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"is_replay", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_replay
    {
      get { return _is_replay; }
      set { _is_replay = value; }
    }
    private int _c_os = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"c_os", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int c_os
    {
      get { return _c_os; }
      set { _c_os = value; }
    }
    private uint _map_crc = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"map_crc", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint map_crc
    {
      get { return _map_crc; }
      set { _map_crc = value; }
    }
    private uint _client_crc = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"client_crc", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint client_crc
    {
      get { return _client_crc; }
      set { _client_crc = value; }
    }
    private uint _string_table_crc = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"string_table_crc", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint string_table_crc
    {
      get { return _string_table_crc; }
      set { _string_table_crc = value; }
    }
    private int _max_clients = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"max_clients", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int max_clients
    {
      get { return _max_clients; }
      set { _max_clients = value; }
    }
    private int _max_classes = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"max_classes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int max_classes
    {
      get { return _max_classes; }
      set { _max_classes = value; }
    }
    private int _player_slot = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"player_slot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_slot
    {
      get { return _player_slot; }
      set { _player_slot = value; }
    }
    private float _tick_interval = default(float);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"tick_interval", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float tick_interval
    {
      get { return _tick_interval; }
      set { _tick_interval = value; }
    }
    private string _game_dir = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"game_dir", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string game_dir
    {
      get { return _game_dir; }
      set { _game_dir = value; }
    }
    private string _map_name = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"map_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string map_name
    {
      get { return _map_name; }
      set { _map_name = value; }
    }
    private string _sky_name = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"sky_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sky_name
    {
      get { return _sky_name; }
      set { _sky_name = value; }
    }
    private string _host_name = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"host_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string host_name
    {
      get { return _host_name; }
      set { _host_name = value; }
    }
    private string _addon_name = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"addon_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string addon_name
    {
      get { return _addon_name; }
      set { _addon_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_ClassInfo")]
  public partial class CSVCMsg_ClassInfo : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_ClassInfo() {}
    
    private bool _create_on_client = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"create_on_client", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool create_on_client
    {
      get { return _create_on_client; }
      set { _create_on_client = value; }
    }
    private readonly global::System.Collections.Generic.List<CSVCMsg_ClassInfo.class_t> _classes = new global::System.Collections.Generic.List<CSVCMsg_ClassInfo.class_t>();
    [global::ProtoBuf.ProtoMember(2, Name=@"classes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVCMsg_ClassInfo.class_t> classes
    {
      get { return _classes; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"class_t")]
  public partial class class_t : global::ProtoBuf.IExtensible
  {
    public class_t() {}
    
    private int _class_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"class_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int class_id
    {
      get { return _class_id; }
      set { _class_id = value; }
    }
    private string _data_table_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data_table_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string data_table_name
    {
      get { return _data_table_name; }
      set { _data_table_name = value; }
    }
    private string _class_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"class_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string class_name
    {
      get { return _class_name; }
      set { _class_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_SetPause")]
  public partial class CSVCMsg_SetPause : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_SetPause() {}
    
    private bool _paused = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"paused", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool paused
    {
      get { return _paused; }
      set { _paused = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_VoiceInit")]
  public partial class CSVCMsg_VoiceInit : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_VoiceInit() {}
    
    private int _quality = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int quality
    {
      get { return _quality; }
      set { _quality = value; }
    }
    private string _codec = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"codec", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string codec
    {
      get { return _codec; }
      set { _codec = value; }
    }
    private int _version = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int version
    {
      get { return _version; }
      set { _version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_Print")]
  public partial class CSVCMsg_Print : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_Print() {}
    
    private string _text = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_Sounds")]
  public partial class CSVCMsg_Sounds : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_Sounds() {}
    
    private bool _reliable_sound = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"reliable_sound", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool reliable_sound
    {
      get { return _reliable_sound; }
      set { _reliable_sound = value; }
    }
    private readonly global::System.Collections.Generic.List<CSVCMsg_Sounds.sounddata_t> _sounds = new global::System.Collections.Generic.List<CSVCMsg_Sounds.sounddata_t>();
    [global::ProtoBuf.ProtoMember(2, Name=@"sounds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVCMsg_Sounds.sounddata_t> sounds
    {
      get { return _sounds; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"sounddata_t")]
  public partial class sounddata_t : global::ProtoBuf.IExtensible
  {
    public sounddata_t() {}
    
    private int _origin_x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"origin_x", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int origin_x
    {
      get { return _origin_x; }
      set { _origin_x = value; }
    }
    private int _origin_y = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"origin_y", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int origin_y
    {
      get { return _origin_y; }
      set { _origin_y = value; }
    }
    private int _origin_z = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"origin_z", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int origin_z
    {
      get { return _origin_z; }
      set { _origin_z = value; }
    }
    private uint _volume = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"volume", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint volume
    {
      get { return _volume; }
      set { _volume = value; }
    }
    private float _delay_value = default(float);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"delay_value", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float delay_value
    {
      get { return _delay_value; }
      set { _delay_value = value; }
    }
    private int _sequence_number = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"sequence_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sequence_number
    {
      get { return _sequence_number; }
      set { _sequence_number = value; }
    }
    private int _entity_index = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"entity_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_index
    {
      get { return _entity_index; }
      set { _entity_index = value; }
    }
    private int _channel = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"channel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int channel
    {
      get { return _channel; }
      set { _channel = value; }
    }
    private int _pitch = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"pitch", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int pitch
    {
      get { return _pitch; }
      set { _pitch = value; }
    }
    private int _flags = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int flags
    {
      get { return _flags; }
      set { _flags = value; }
    }
    private uint _sound_num = default(uint);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"sound_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint sound_num
    {
      get { return _sound_num; }
      set { _sound_num = value; }
    }
    private uint _sound_num_handle = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"sound_num_handle", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint sound_num_handle
    {
      get { return _sound_num_handle; }
      set { _sound_num_handle = value; }
    }
    private int _speaker_entity = default(int);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"speaker_entity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int speaker_entity
    {
      get { return _speaker_entity; }
      set { _speaker_entity = value; }
    }
    private int _random_seed = default(int);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"random_seed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int random_seed
    {
      get { return _random_seed; }
      set { _random_seed = value; }
    }
    private int _sound_level = default(int);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"sound_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sound_level
    {
      get { return _sound_level; }
      set { _sound_level = value; }
    }
    private bool _is_sentence = default(bool);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"is_sentence", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_sentence
    {
      get { return _is_sentence; }
      set { _is_sentence = value; }
    }
    private bool _is_ambient = default(bool);
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"is_ambient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_ambient
    {
      get { return _is_ambient; }
      set { _is_ambient = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_Prefetch")]
  public partial class CSVCMsg_Prefetch : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_Prefetch() {}
    
    private int _sound_index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sound_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sound_index
    {
      get { return _sound_index; }
      set { _sound_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_SetView")]
  public partial class CSVCMsg_SetView : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_SetView() {}
    
    private int _entity_index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"entity_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_index
    {
      get { return _entity_index; }
      set { _entity_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_FixAngle")]
  public partial class CSVCMsg_FixAngle : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_FixAngle() {}
    
    private bool _relative = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"relative", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool relative
    {
      get { return _relative; }
      set { _relative = value; }
    }
    private CMsgQAngle _angle = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"angle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgQAngle angle
    {
      get { return _angle; }
      set { _angle = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_CrosshairAngle")]
  public partial class CSVCMsg_CrosshairAngle : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_CrosshairAngle() {}
    
    private CMsgQAngle _angle = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"angle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgQAngle angle
    {
      get { return _angle; }
      set { _angle = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_BSPDecal")]
  public partial class CSVCMsg_BSPDecal : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_BSPDecal() {}
    
    private CMsgVector _pos = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private int _decal_texture_index = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"decal_texture_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int decal_texture_index
    {
      get { return _decal_texture_index; }
      set { _decal_texture_index = value; }
    }
    private int _entity_index = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"entity_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int entity_index
    {
      get { return _entity_index; }
      set { _entity_index = value; }
    }
    private int _model_index = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"model_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int model_index
    {
      get { return _model_index; }
      set { _model_index = value; }
    }
    private bool _low_priority = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"low_priority", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool low_priority
    {
      get { return _low_priority; }
      set { _low_priority = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_SplitScreen")]
  public partial class CSVCMsg_SplitScreen : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_SplitScreen() {}
    
    private ESplitScreenMessageType _type = ESplitScreenMessageType.MSG_SPLITSCREEN_ADDUSER;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(ESplitScreenMessageType.MSG_SPLITSCREEN_ADDUSER)]
    public ESplitScreenMessageType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _slot = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"slot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int slot
    {
      get { return _slot; }
      set { _slot = value; }
    }
    private int _player_index = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"player_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_index
    {
      get { return _player_index; }
      set { _player_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_GetCvarValue")]
  public partial class CSVCMsg_GetCvarValue : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_GetCvarValue() {}
    
    private int _cookie = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cookie", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cookie
    {
      get { return _cookie; }
      set { _cookie = value; }
    }
    private string _cvar_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cvar_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cvar_name
    {
      get { return _cvar_name; }
      set { _cvar_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_Menu")]
  public partial class CSVCMsg_Menu : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_Menu() {}
    
    private int _dialog_type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"dialog_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int dialog_type
    {
      get { return _dialog_type; }
      set { _dialog_type = value; }
    }
    private byte[] _menu_key_values = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"menu_key_values", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] menu_key_values
    {
      get { return _menu_key_values; }
      set { _menu_key_values = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_SendTable")]
  public partial class CSVCMsg_SendTable : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_SendTable() {}
    
    private bool _is_end = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"is_end", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_end
    {
      get { return _is_end; }
      set { _is_end = value; }
    }
    private string _net_table_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"net_table_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string net_table_name
    {
      get { return _net_table_name; }
      set { _net_table_name = value; }
    }
    private bool _needs_decoder = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"needs_decoder", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool needs_decoder
    {
      get { return _needs_decoder; }
      set { _needs_decoder = value; }
    }
    private readonly global::System.Collections.Generic.List<CSVCMsg_SendTable.sendprop_t> _props = new global::System.Collections.Generic.List<CSVCMsg_SendTable.sendprop_t>();
    [global::ProtoBuf.ProtoMember(4, Name=@"props", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVCMsg_SendTable.sendprop_t> props
    {
      get { return _props; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"sendprop_t")]
  public partial class sendprop_t : global::ProtoBuf.IExtensible
  {
    public sendprop_t() {}
    
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private string _var_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"var_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string var_name
    {
      get { return _var_name; }
      set { _var_name = value; }
    }
    private int _flags = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int flags
    {
      get { return _flags; }
      set { _flags = value; }
    }
    private int _priority = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int priority
    {
      get { return _priority; }
      set { _priority = value; }
    }
    private string _dt_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"dt_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string dt_name
    {
      get { return _dt_name; }
      set { _dt_name = value; }
    }
    private int _num_elements = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"num_elements", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num_elements
    {
      get { return _num_elements; }
      set { _num_elements = value; }
    }
    private float _low_value = default(float);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"low_value", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float low_value
    {
      get { return _low_value; }
      set { _low_value = value; }
    }
    private float _high_value = default(float);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"high_value", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float high_value
    {
      get { return _high_value; }
      set { _high_value = value; }
    }
    private int _num_bits = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"num_bits", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num_bits
    {
      get { return _num_bits; }
      set { _num_bits = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_GameEventList")]
  public partial class CSVCMsg_GameEventList : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_GameEventList() {}
    
    private readonly global::System.Collections.Generic.List<CSVCMsg_GameEventList.descriptor_t> _descriptors = new global::System.Collections.Generic.List<CSVCMsg_GameEventList.descriptor_t>();
    [global::ProtoBuf.ProtoMember(1, Name=@"descriptors", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVCMsg_GameEventList.descriptor_t> descriptors
    {
      get { return _descriptors; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"key_t")]
  public partial class key_t : global::ProtoBuf.IExtensible
  {
    public key_t() {}
    
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"descriptor_t")]
  public partial class descriptor_t : global::ProtoBuf.IExtensible
  {
    public descriptor_t() {}
    
    private int _eventid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"eventid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int eventid
    {
      get { return _eventid; }
      set { _eventid = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private readonly global::System.Collections.Generic.List<CSVCMsg_GameEventList.key_t> _keys = new global::System.Collections.Generic.List<CSVCMsg_GameEventList.key_t>();
    [global::ProtoBuf.ProtoMember(3, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVCMsg_GameEventList.key_t> keys
    {
      get { return _keys; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_PacketEntities")]
  public partial class CSVCMsg_PacketEntities : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_PacketEntities() {}
    
    private int _max_entries = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"max_entries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int max_entries
    {
      get { return _max_entries; }
      set { _max_entries = value; }
    }
    private int _updated_entries = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"updated_entries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int updated_entries
    {
      get { return _updated_entries; }
      set { _updated_entries = value; }
    }
    private bool _is_delta = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"is_delta", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_delta
    {
      get { return _is_delta; }
      set { _is_delta = value; }
    }
    private bool _update_baseline = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"update_baseline", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool update_baseline
    {
      get { return _update_baseline; }
      set { _update_baseline = value; }
    }
    private int _baseline = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"baseline", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int baseline
    {
      get { return _baseline; }
      set { _baseline = value; }
    }
    private int _delta_from = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"delta_from", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int delta_from
    {
      get { return _delta_from; }
      set { _delta_from = value; }
    }
    private byte[] _entity_data = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"entity_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] entity_data
    {
      get { return _entity_data; }
      set { _entity_data = value; }
    }
    private bool _pending_full_frame = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pending_full_frame", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool pending_full_frame
    {
      get { return _pending_full_frame; }
      set { _pending_full_frame = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_TempEntities")]
  public partial class CSVCMsg_TempEntities : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_TempEntities() {}
    
    private bool _reliable = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"reliable", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool reliable
    {
      get { return _reliable; }
      set { _reliable = value; }
    }
    private int _num_entries = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"num_entries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num_entries
    {
      get { return _num_entries; }
      set { _num_entries = value; }
    }
    private byte[] _entity_data = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"entity_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] entity_data
    {
      get { return _entity_data; }
      set { _entity_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_CreateStringTable")]
  public partial class CSVCMsg_CreateStringTable : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_CreateStringTable() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _max_entries = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"max_entries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int max_entries
    {
      get { return _max_entries; }
      set { _max_entries = value; }
    }
    private int _num_entries = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"num_entries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num_entries
    {
      get { return _num_entries; }
      set { _num_entries = value; }
    }
    private bool _user_data_fixed_size = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"user_data_fixed_size", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool user_data_fixed_size
    {
      get { return _user_data_fixed_size; }
      set { _user_data_fixed_size = value; }
    }
    private int _user_data_size = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"user_data_size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int user_data_size
    {
      get { return _user_data_size; }
      set { _user_data_size = value; }
    }
    private int _user_data_size_bits = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"user_data_size_bits", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int user_data_size_bits
    {
      get { return _user_data_size_bits; }
      set { _user_data_size_bits = value; }
    }
    private int _flags = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int flags
    {
      get { return _flags; }
      set { _flags = value; }
    }
    private byte[] _string_data = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"string_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] string_data
    {
      get { return _string_data; }
      set { _string_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_UpdateStringTable")]
  public partial class CSVCMsg_UpdateStringTable : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_UpdateStringTable() {}
    
    private int _table_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"table_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int table_id
    {
      get { return _table_id; }
      set { _table_id = value; }
    }
    private int _num_changed_entries = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"num_changed_entries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num_changed_entries
    {
      get { return _num_changed_entries; }
      set { _num_changed_entries = value; }
    }
    private byte[] _string_data = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"string_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] string_data
    {
      get { return _string_data; }
      set { _string_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_VoiceData")]
  public partial class CSVCMsg_VoiceData : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_VoiceData() {}
    
    private int _client = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"client", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int client
    {
      get { return _client; }
      set { _client = value; }
    }
    private bool _proximity = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"proximity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool proximity
    {
      get { return _proximity; }
      set { _proximity = value; }
    }
    private ulong _xuid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"xuid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong xuid
    {
      get { return _xuid; }
      set { _xuid = value; }
    }
    private int _audible_mask = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"audible_mask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int audible_mask
    {
      get { return _audible_mask; }
      set { _audible_mask = value; }
    }
    private byte[] _voice_data = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"voice_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] voice_data
    {
      get { return _voice_data; }
      set { _voice_data = value; }
    }
    private VoiceDataFormat_t _format = VoiceDataFormat_t.VOICEDATA_FORMAT_STEAM;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"format", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(VoiceDataFormat_t.VOICEDATA_FORMAT_STEAM)]
    public VoiceDataFormat_t format
    {
      get { return _format; }
      set { _format = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_PacketReliable")]
  public partial class CSVCMsg_PacketReliable : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_PacketReliable() {}
    
    private int _tick = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tick", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int tick
    {
      get { return _tick; }
      set { _tick = value; }
    }
    private int _messagessize = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"messagessize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int messagessize
    {
      get { return _messagessize; }
      set { _messagessize = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_FullFrameSplit")]
  public partial class CSVCMsg_FullFrameSplit : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_FullFrameSplit() {}
    
    private int _tick = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tick", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int tick
    {
      get { return _tick; }
      set { _tick = value; }
    }
    private int _section = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"section", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int section
    {
      get { return _section; }
      set { _section = value; }
    }
    private int _total = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"total", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int total
    {
      get { return _total; }
      set { _total = value; }
    }
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgVector")]
  public partial class CMsgVector : global::ProtoBuf.IExtensible
  {
    public CMsgVector() {}
    
    private float _x = default(float);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgVector2D")]
  public partial class CMsgVector2D : global::ProtoBuf.IExtensible
  {
    public CMsgVector2D() {}
    
    private float _x = default(float);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgQAngle")]
  public partial class CMsgQAngle : global::ProtoBuf.IExtensible
  {
    public CMsgQAngle() {}
    
    private float _x = default(float);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_GameEvent")]
  public partial class CSVCMsg_GameEvent : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_GameEvent() {}
    
    private string _event_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"event_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string event_name
    {
      get { return _event_name; }
      set { _event_name = value; }
    }
    private int _eventid = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"eventid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int eventid
    {
      get { return _eventid; }
      set { _eventid = value; }
    }
    private readonly global::System.Collections.Generic.List<CSVCMsg_GameEvent.key_t> _keys = new global::System.Collections.Generic.List<CSVCMsg_GameEvent.key_t>();
    [global::ProtoBuf.ProtoMember(3, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVCMsg_GameEvent.key_t> keys
    {
      get { return _keys; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"key_t")]
  public partial class key_t : global::ProtoBuf.IExtensible
  {
    public key_t() {}
    
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private string _val_string = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"val_string", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string val_string
    {
      get { return _val_string; }
      set { _val_string = value; }
    }
    private float _val_float = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"val_float", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float val_float
    {
      get { return _val_float; }
      set { _val_float = value; }
    }
    private int _val_long = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"val_long", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int val_long
    {
      get { return _val_long; }
      set { _val_long = value; }
    }
    private int _val_short = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"val_short", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int val_short
    {
      get { return _val_short; }
      set { _val_short = value; }
    }
    private int _val_byte = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"val_byte", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int val_byte
    {
      get { return _val_byte; }
      set { _val_byte = value; }
    }
    private bool _val_bool = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"val_bool", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool val_bool
    {
      get { return _val_bool; }
      set { _val_bool = value; }
    }
    private ulong _val_uint64 = default(ulong);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"val_uint64", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong val_uint64
    {
      get { return _val_uint64; }
      set { _val_uint64 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsgList_GameEvents")]
  public partial class CSVCMsgList_GameEvents : global::ProtoBuf.IExtensible
  {
    public CSVCMsgList_GameEvents() {}
    
    private readonly global::System.Collections.Generic.List<CSVCMsgList_GameEvents.event_t> _events = new global::System.Collections.Generic.List<CSVCMsgList_GameEvents.event_t>();
    [global::ProtoBuf.ProtoMember(1, Name=@"events", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVCMsgList_GameEvents.event_t> events
    {
      get { return _events; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"event_t")]
  public partial class event_t : global::ProtoBuf.IExtensible
  {
    public event_t() {}
    
    private int _tick = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tick", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int tick
    {
      get { return _tick; }
      set { _tick = value; }
    }
    private CSVCMsg_GameEvent _event = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"event", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CSVCMsg_GameEvent @event
    {
      get { return _event; }
      set { _event = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsg_UserMessage")]
  public partial class CSVCMsg_UserMessage : global::ProtoBuf.IExtensible
  {
    public CSVCMsg_UserMessage() {}
    
    private int _msg_type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msg_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int msg_type
    {
      get { return _msg_type; }
      set { _msg_type = value; }
    }
    private byte[] _msg_data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"msg_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] msg_data
    {
      get { return _msg_data; }
      set { _msg_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVCMsgList_UserMessages")]
  public partial class CSVCMsgList_UserMessages : global::ProtoBuf.IExtensible
  {
    public CSVCMsgList_UserMessages() {}
    
    private readonly global::System.Collections.Generic.List<CSVCMsgList_UserMessages.usermsg_t> _usermsgs = new global::System.Collections.Generic.List<CSVCMsgList_UserMessages.usermsg_t>();
    [global::ProtoBuf.ProtoMember(1, Name=@"usermsgs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVCMsgList_UserMessages.usermsg_t> usermsgs
    {
      get { return _usermsgs; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"usermsg_t")]
  public partial class usermsg_t : global::ProtoBuf.IExtensible
  {
    public usermsg_t() {}
    
    private int _tick = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tick", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int tick
    {
      get { return _tick; }
      set { _tick = value; }
    }
    private CSVCMsg_UserMessage _msg = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CSVCMsg_UserMessage msg
    {
      get { return _msg; }
      set { _msg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_AchievementEvent")]
  public partial class CUserMsg_AchievementEvent : global::ProtoBuf.IExtensible
  {
    public CUserMsg_AchievementEvent() {}
    
    private uint _achievement = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"achievement", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint achievement
    {
      get { return _achievement; }
      set { _achievement = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_CloseCaption")]
  public partial class CUserMsg_CloseCaption : global::ProtoBuf.IExtensible
  {
    public CUserMsg_CloseCaption() {}
    
    private uint _hash = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hash", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint hash
    {
      get { return _hash; }
      set { _hash = value; }
    }
    private float _duration = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private bool _from_player = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"from_player", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool from_player
    {
      get { return _from_player; }
      set { _from_player = value; }
    }
    private int _ent_index = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ent_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ent_index
    {
      get { return _ent_index; }
      set { _ent_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_CurrentTimescale")]
  public partial class CUserMsg_CurrentTimescale : global::ProtoBuf.IExtensible
  {
    public CUserMsg_CurrentTimescale() {}
    
    private float _current = default(float);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"current", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float current
    {
      get { return _current; }
      set { _current = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_DesiredTimescale")]
  public partial class CUserMsg_DesiredTimescale : global::ProtoBuf.IExtensible
  {
    public CUserMsg_DesiredTimescale() {}
    
    private float _desired = default(float);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"desired", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float desired
    {
      get { return _desired; }
      set { _desired = value; }
    }
    private float _duration = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private uint _interpolator = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"interpolator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint interpolator
    {
      get { return _interpolator; }
      set { _interpolator = value; }
    }
    private float _start_blend_time = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"start_blend_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float start_blend_time
    {
      get { return _start_blend_time; }
      set { _start_blend_time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_Fade")]
  public partial class CUserMsg_Fade : global::ProtoBuf.IExtensible
  {
    public CUserMsg_Fade() {}
    
    private uint _duration = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private uint _hold_time = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"hold_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint hold_time
    {
      get { return _hold_time; }
      set { _hold_time = value; }
    }
    private uint _flags = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint flags
    {
      get { return _flags; }
      set { _flags = value; }
    }
    private uint _color = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"color", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint color
    {
      get { return _color; }
      set { _color = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_Shake")]
  public partial class CUserMsg_Shake : global::ProtoBuf.IExtensible
  {
    public CUserMsg_Shake() {}
    
    private uint _command = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint command
    {
      get { return _command; }
      set { _command = value; }
    }
    private float _amplitude = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"amplitude", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float amplitude
    {
      get { return _amplitude; }
      set { _amplitude = value; }
    }
    private float _frequency = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"frequency", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float frequency
    {
      get { return _frequency; }
      set { _frequency = value; }
    }
    private float _duration = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_ShakeDir")]
  public partial class CUserMsg_ShakeDir : global::ProtoBuf.IExtensible
  {
    public CUserMsg_ShakeDir() {}
    
    private CUserMsg_Shake _shake = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"shake", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CUserMsg_Shake shake
    {
      get { return _shake; }
      set { _shake = value; }
    }
    private CMsgVector _direction = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"direction", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector direction
    {
      get { return _direction; }
      set { _direction = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_Tilt")]
  public partial class CUserMsg_Tilt : global::ProtoBuf.IExtensible
  {
    public CUserMsg_Tilt() {}
    
    private uint _command = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint command
    {
      get { return _command; }
      set { _command = value; }
    }
    private bool _ease_in_out = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ease_in_out", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool ease_in_out
    {
      get { return _ease_in_out; }
      set { _ease_in_out = value; }
    }
    private CMsgVector _angle = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"angle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector angle
    {
      get { return _angle; }
      set { _angle = value; }
    }
    private float _duration = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private float _time = default(float);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float time
    {
      get { return _time; }
      set { _time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_SayText")]
  public partial class CUserMsg_SayText : global::ProtoBuf.IExtensible
  {
    public CUserMsg_SayText() {}
    
    private uint _client = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"client", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint client
    {
      get { return _client; }
      set { _client = value; }
    }
    private string _text = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text
    {
      get { return _text; }
      set { _text = value; }
    }
    private bool _chat = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"chat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool chat
    {
      get { return _chat; }
      set { _chat = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_SayText2")]
  public partial class CUserMsg_SayText2 : global::ProtoBuf.IExtensible
  {
    public CUserMsg_SayText2() {}
    
    private uint _client = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"client", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint client
    {
      get { return _client; }
      set { _client = value; }
    }
    private bool _chat = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"chat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool chat
    {
      get { return _chat; }
      set { _chat = value; }
    }
    private string _format = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"format", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string format
    {
      get { return _format; }
      set { _format = value; }
    }
    private string _prefix = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"prefix", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string prefix
    {
      get { return _prefix; }
      set { _prefix = value; }
    }
    private string _text = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text
    {
      get { return _text; }
      set { _text = value; }
    }
    private string _location = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string location
    {
      get { return _location; }
      set { _location = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_HudMsg")]
  public partial class CUserMsg_HudMsg : global::ProtoBuf.IExtensible
  {
    public CUserMsg_HudMsg() {}
    
    private uint _channel = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"channel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint channel
    {
      get { return _channel; }
      set { _channel = value; }
    }
    private float _x = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y = default(float);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private uint _color1 = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"color1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint color1
    {
      get { return _color1; }
      set { _color1 = value; }
    }
    private uint _color2 = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"color2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint color2
    {
      get { return _color2; }
      set { _color2 = value; }
    }
    private uint _effect = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"effect", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint effect
    {
      get { return _effect; }
      set { _effect = value; }
    }
    private float _fade_in_time = default(float);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"fade_in_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float fade_in_time
    {
      get { return _fade_in_time; }
      set { _fade_in_time = value; }
    }
    private float _fade_out_time = default(float);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"fade_out_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float fade_out_time
    {
      get { return _fade_out_time; }
      set { _fade_out_time = value; }
    }
    private float _hold_time = default(float);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"hold_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float hold_time
    {
      get { return _hold_time; }
      set { _hold_time = value; }
    }
    private float _fx_time = default(float);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"fx_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float fx_time
    {
      get { return _fx_time; }
      set { _fx_time = value; }
    }
    private string _message = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string message
    {
      get { return _message; }
      set { _message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_HudText")]
  public partial class CUserMsg_HudText : global::ProtoBuf.IExtensible
  {
    public CUserMsg_HudText() {}
    
    private string _message = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string message
    {
      get { return _message; }
      set { _message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_TextMsg")]
  public partial class CUserMsg_TextMsg : global::ProtoBuf.IExtensible
  {
    public CUserMsg_TextMsg() {}
    
    private uint _dest = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"dest", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dest
    {
      get { return _dest; }
      set { _dest = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _param = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(2, Name=@"param", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> param
    {
      get { return _param; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_GameTitle")]
  public partial class CUserMsg_GameTitle : global::ProtoBuf.IExtensible
  {
    public CUserMsg_GameTitle() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_ResetHUD")]
  public partial class CUserMsg_ResetHUD : global::ProtoBuf.IExtensible
  {
    public CUserMsg_ResetHUD() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_SendAudio")]
  public partial class CUserMsg_SendAudio : global::ProtoBuf.IExtensible
  {
    public CUserMsg_SendAudio() {}
    
    private bool _stop = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"stop", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool stop
    {
      get { return _stop; }
      set { _stop = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_VoiceMask")]
  public partial class CUserMsg_VoiceMask : global::ProtoBuf.IExtensible
  {
    public CUserMsg_VoiceMask() {}
    
    private readonly global::System.Collections.Generic.List<int> _audible_players_mask = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"audible_players_mask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> audible_players_mask
    {
      get { return _audible_players_mask; }
    }
  
    private bool _player_mod_enabled = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"player_mod_enabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool player_mod_enabled
    {
      get { return _player_mod_enabled; }
      set { _player_mod_enabled = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_RequestState")]
  public partial class CUserMsg_RequestState : global::ProtoBuf.IExtensible
  {
    public CUserMsg_RequestState() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_HintText")]
  public partial class CUserMsg_HintText : global::ProtoBuf.IExtensible
  {
    public CUserMsg_HintText() {}
    
    private string _message = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string message
    {
      get { return _message; }
      set { _message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_KeyHintText")]
  public partial class CUserMsg_KeyHintText : global::ProtoBuf.IExtensible
  {
    public CUserMsg_KeyHintText() {}
    
    private readonly global::System.Collections.Generic.List<string> _messages = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"messages", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> messages
    {
      get { return _messages; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_StatsCrawlMsg")]
  public partial class CUserMsg_StatsCrawlMsg : global::ProtoBuf.IExtensible
  {
    public CUserMsg_StatsCrawlMsg() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_StatsSkipState")]
  public partial class CUserMsg_StatsSkipState : global::ProtoBuf.IExtensible
  {
    public CUserMsg_StatsSkipState() {}
    
    private int _num_skips = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"num_skips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num_skips
    {
      get { return _num_skips; }
      set { _num_skips = value; }
    }
    private int _num_players = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"num_players", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num_players
    {
      get { return _num_players; }
      set { _num_players = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_VoiceSubtitle")]
  public partial class CUserMsg_VoiceSubtitle : global::ProtoBuf.IExtensible
  {
    public CUserMsg_VoiceSubtitle() {}
    
    private int _ent_index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ent_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ent_index
    {
      get { return _ent_index; }
      set { _ent_index = value; }
    }
    private int _menu = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"menu", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int menu
    {
      get { return _menu; }
      set { _menu = value; }
    }
    private int _item = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"item", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int item
    {
      get { return _item; }
      set { _item = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_VGUIMenu")]
  public partial class CUserMsg_VGUIMenu : global::ProtoBuf.IExtensible
  {
    public CUserMsg_VGUIMenu() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private bool _show = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"show", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool show
    {
      get { return _show; }
      set { _show = value; }
    }
    private readonly global::System.Collections.Generic.List<CUserMsg_VGUIMenu.Keys> _keys = new global::System.Collections.Generic.List<CUserMsg_VGUIMenu.Keys>();
    [global::ProtoBuf.ProtoMember(3, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CUserMsg_VGUIMenu.Keys> keys
    {
      get { return _keys; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Keys")]
  public partial class Keys : global::ProtoBuf.IExtensible
  {
    public Keys() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _value = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_Geiger")]
  public partial class CUserMsg_Geiger : global::ProtoBuf.IExtensible
  {
    public CUserMsg_Geiger() {}
    
    private int _range = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"range", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int range
    {
      get { return _range; }
      set { _range = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_Rumble")]
  public partial class CUserMsg_Rumble : global::ProtoBuf.IExtensible
  {
    public CUserMsg_Rumble() {}
    
    private int _index = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private int _data = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int data
    {
      get { return _data; }
      set { _data = value; }
    }
    private int _flags = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int flags
    {
      get { return _flags; }
      set { _flags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_Train")]
  public partial class CUserMsg_Train : global::ProtoBuf.IExtensible
  {
    public CUserMsg_Train() {}
    
    private int _train = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"train", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int train
    {
      get { return _train; }
      set { _train = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_SayTextChannel")]
  public partial class CUserMsg_SayTextChannel : global::ProtoBuf.IExtensible
  {
    public CUserMsg_SayTextChannel() {}
    
    private int _player = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player
    {
      get { return _player; }
      set { _player = value; }
    }
    private int _channel = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"channel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int channel
    {
      get { return _channel; }
      set { _channel = value; }
    }
    private string _text = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_MessageText")]
  public partial class CUserMsg_MessageText : global::ProtoBuf.IExtensible
  {
    public CUserMsg_MessageText() {}
    
    private uint _color = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint color
    {
      get { return _color; }
      set { _color = value; }
    }
    private string _text = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CUserMsg_CameraTransition")]
  public partial class CUserMsg_CameraTransition : global::ProtoBuf.IExtensible
  {
    public CUserMsg_CameraTransition() {}
    
    private uint _camera_type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"camera_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint camera_type
    {
      get { return _camera_type; }
      set { _camera_type = value; }
    }
    private float _duration = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private CUserMsg_CameraTransition.Transition_DataDriven _params_data_driven = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"params_data_driven", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CUserMsg_CameraTransition.Transition_DataDriven params_data_driven
    {
      get { return _params_data_driven; }
      set { _params_data_driven = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Transition_DataDriven")]
  public partial class Transition_DataDriven : global::ProtoBuf.IExtensible
  {
    public Transition_DataDriven() {}
    
    private string _filename = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filename
    {
      get { return _filename; }
      set { _filename = value; }
    }
    private int _attach_ent_index = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"attach_ent_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int attach_ent_index
    {
      get { return _attach_ent_index; }
      set { _attach_ent_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"Activity")]
    public enum Activity
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_INVALID", Value=-1)]
      ACT_INVALID = -1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RESET", Value=0)]
      ACT_RESET = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE", Value=1)]
      ACT_IDLE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_TRANSITION", Value=2)]
      ACT_TRANSITION = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_COVER", Value=3)]
      ACT_COVER = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_COVER_MED", Value=4)]
      ACT_COVER_MED = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_COVER_LOW", Value=5)]
      ACT_COVER_LOW = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK", Value=6)]
      ACT_WALK = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM", Value=7)]
      ACT_WALK_AIM = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_CROUCH", Value=8)]
      ACT_WALK_CROUCH = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_CROUCH_AIM", Value=9)]
      ACT_WALK_CROUCH_AIM = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN", Value=10)]
      ACT_RUN = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM", Value=11)]
      ACT_RUN_AIM = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_CROUCH", Value=12)]
      ACT_RUN_CROUCH = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_CROUCH_AIM", Value=13)]
      ACT_RUN_CROUCH_AIM = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_PROTECTED", Value=14)]
      ACT_RUN_PROTECTED = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SCRIPT_CUSTOM_MOVE", Value=15)]
      ACT_SCRIPT_CUSTOM_MOVE = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK1", Value=16)]
      ACT_RANGE_ATTACK1 = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK2", Value=17)]
      ACT_RANGE_ATTACK2 = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK1_LOW", Value=18)]
      ACT_RANGE_ATTACK1_LOW = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK2_LOW", Value=19)]
      ACT_RANGE_ATTACK2_LOW = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIESIMPLE", Value=20)]
      ACT_DIESIMPLE = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIEBACKWARD", Value=21)]
      ACT_DIEBACKWARD = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIEFORWARD", Value=22)]
      ACT_DIEFORWARD = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIEVIOLENT", Value=23)]
      ACT_DIEVIOLENT = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIERAGDOLL", Value=24)]
      ACT_DIERAGDOLL = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLY", Value=25)]
      ACT_FLY = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_HOVER", Value=26)]
      ACT_HOVER = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GLIDE", Value=27)]
      ACT_GLIDE = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SWIM", Value=28)]
      ACT_SWIM = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_JUMP", Value=29)]
      ACT_JUMP = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_HOP", Value=30)]
      ACT_HOP = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_LEAP", Value=31)]
      ACT_LEAP = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_LAND", Value=32)]
      ACT_LAND = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_CLIMB_UP", Value=33)]
      ACT_CLIMB_UP = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_CLIMB_DOWN", Value=34)]
      ACT_CLIMB_DOWN = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_CLIMB_DISMOUNT", Value=35)]
      ACT_CLIMB_DISMOUNT = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SHIPLADDER_UP", Value=36)]
      ACT_SHIPLADDER_UP = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SHIPLADDER_DOWN", Value=37)]
      ACT_SHIPLADDER_DOWN = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_STRAFE_LEFT", Value=38)]
      ACT_STRAFE_LEFT = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_STRAFE_RIGHT", Value=39)]
      ACT_STRAFE_RIGHT = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_ROLL_LEFT", Value=40)]
      ACT_ROLL_LEFT = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_ROLL_RIGHT", Value=41)]
      ACT_ROLL_RIGHT = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_TURN_LEFT", Value=42)]
      ACT_TURN_LEFT = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_TURN_RIGHT", Value=43)]
      ACT_TURN_RIGHT = 43,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_CROUCH", Value=44)]
      ACT_CROUCH = 44,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_CROUCHIDLE", Value=45)]
      ACT_CROUCHIDLE = 45,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_STAND", Value=46)]
      ACT_STAND = 46,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_USE", Value=47)]
      ACT_USE = 47,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_ALIEN_BURROW_IDLE", Value=48)]
      ACT_ALIEN_BURROW_IDLE = 48,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_ALIEN_BURROW_OUT", Value=49)]
      ACT_ALIEN_BURROW_OUT = 49,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL1", Value=50)]
      ACT_SIGNAL1 = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL2", Value=51)]
      ACT_SIGNAL2 = 51,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL3", Value=52)]
      ACT_SIGNAL3 = 52,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL_ADVANCE", Value=53)]
      ACT_SIGNAL_ADVANCE = 53,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL_FORWARD", Value=54)]
      ACT_SIGNAL_FORWARD = 54,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL_GROUP", Value=55)]
      ACT_SIGNAL_GROUP = 55,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL_HALT", Value=56)]
      ACT_SIGNAL_HALT = 56,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL_LEFT", Value=57)]
      ACT_SIGNAL_LEFT = 57,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL_RIGHT", Value=58)]
      ACT_SIGNAL_RIGHT = 58,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SIGNAL_TAKECOVER", Value=59)]
      ACT_SIGNAL_TAKECOVER = 59,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_LOOKBACK_RIGHT", Value=60)]
      ACT_LOOKBACK_RIGHT = 60,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_LOOKBACK_LEFT", Value=61)]
      ACT_LOOKBACK_LEFT = 61,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_COWER", Value=62)]
      ACT_COWER = 62,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SMALL_FLINCH", Value=63)]
      ACT_SMALL_FLINCH = 63,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BIG_FLINCH", Value=64)]
      ACT_BIG_FLINCH = 64,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_MELEE_ATTACK1", Value=65)]
      ACT_MELEE_ATTACK1 = 65,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_MELEE_ATTACK2", Value=66)]
      ACT_MELEE_ATTACK2 = 66,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD", Value=67)]
      ACT_RELOAD = 67,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD_START", Value=68)]
      ACT_RELOAD_START = 68,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD_FINISH", Value=69)]
      ACT_RELOAD_FINISH = 69,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD_LOW", Value=70)]
      ACT_RELOAD_LOW = 70,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_ARM", Value=71)]
      ACT_ARM = 71,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DISARM", Value=72)]
      ACT_DISARM = 72,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DROP_WEAPON", Value=73)]
      ACT_DROP_WEAPON = 73,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DROP_WEAPON_SHOTGUN", Value=74)]
      ACT_DROP_WEAPON_SHOTGUN = 74,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_PICKUP_GROUND", Value=75)]
      ACT_PICKUP_GROUND = 75,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_PICKUP_RACK", Value=76)]
      ACT_PICKUP_RACK = 76,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_ANGRY", Value=77)]
      ACT_IDLE_ANGRY = 77,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_RELAXED", Value=78)]
      ACT_IDLE_RELAXED = 78,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_STIMULATED", Value=79)]
      ACT_IDLE_STIMULATED = 79,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_AGITATED", Value=80)]
      ACT_IDLE_AGITATED = 80,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_STEALTH", Value=81)]
      ACT_IDLE_STEALTH = 81,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_HURT", Value=82)]
      ACT_IDLE_HURT = 82,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_RELAXED", Value=83)]
      ACT_WALK_RELAXED = 83,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_STIMULATED", Value=84)]
      ACT_WALK_STIMULATED = 84,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AGITATED", Value=85)]
      ACT_WALK_AGITATED = 85,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_STEALTH", Value=86)]
      ACT_WALK_STEALTH = 86,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_RELAXED", Value=87)]
      ACT_RUN_RELAXED = 87,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_STIMULATED", Value=88)]
      ACT_RUN_STIMULATED = 88,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AGITATED", Value=89)]
      ACT_RUN_AGITATED = 89,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_STEALTH", Value=90)]
      ACT_RUN_STEALTH = 90,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_AIM_RELAXED", Value=91)]
      ACT_IDLE_AIM_RELAXED = 91,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_AIM_STIMULATED", Value=92)]
      ACT_IDLE_AIM_STIMULATED = 92,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_AIM_AGITATED", Value=93)]
      ACT_IDLE_AIM_AGITATED = 93,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_AIM_STEALTH", Value=94)]
      ACT_IDLE_AIM_STEALTH = 94,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM_RELAXED", Value=95)]
      ACT_WALK_AIM_RELAXED = 95,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM_STIMULATED", Value=96)]
      ACT_WALK_AIM_STIMULATED = 96,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM_AGITATED", Value=97)]
      ACT_WALK_AIM_AGITATED = 97,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM_STEALTH", Value=98)]
      ACT_WALK_AIM_STEALTH = 98,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM_RELAXED", Value=99)]
      ACT_RUN_AIM_RELAXED = 99,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM_STIMULATED", Value=100)]
      ACT_RUN_AIM_STIMULATED = 100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM_AGITATED", Value=101)]
      ACT_RUN_AIM_AGITATED = 101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM_STEALTH", Value=102)]
      ACT_RUN_AIM_STEALTH = 102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_CROUCHIDLE_STIMULATED", Value=103)]
      ACT_CROUCHIDLE_STIMULATED = 103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_CROUCHIDLE_AIM_STIMULATED", Value=104)]
      ACT_CROUCHIDLE_AIM_STIMULATED = 104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_CROUCHIDLE_AGITATED", Value=105)]
      ACT_CROUCHIDLE_AGITATED = 105,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_HURT", Value=106)]
      ACT_WALK_HURT = 106,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_HURT", Value=107)]
      ACT_RUN_HURT = 107,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SPECIAL_ATTACK1", Value=108)]
      ACT_SPECIAL_ATTACK1 = 108,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SPECIAL_ATTACK2", Value=109)]
      ACT_SPECIAL_ATTACK2 = 109,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_COMBAT_IDLE", Value=110)]
      ACT_COMBAT_IDLE = 110,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_SCARED", Value=111)]
      ACT_WALK_SCARED = 111,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_SCARED", Value=112)]
      ACT_RUN_SCARED = 112,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VICTORY_DANCE", Value=113)]
      ACT_VICTORY_DANCE = 113,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIE_HEADSHOT", Value=114)]
      ACT_DIE_HEADSHOT = 114,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIE_CHESTSHOT", Value=115)]
      ACT_DIE_CHESTSHOT = 115,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIE_GUTSHOT", Value=116)]
      ACT_DIE_GUTSHOT = 116,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIE_BACKSHOT", Value=117)]
      ACT_DIE_BACKSHOT = 117,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_HEAD", Value=118)]
      ACT_FLINCH_HEAD = 118,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_CHEST", Value=119)]
      ACT_FLINCH_CHEST = 119,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_STOMACH", Value=120)]
      ACT_FLINCH_STOMACH = 120,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_LEFTARM", Value=121)]
      ACT_FLINCH_LEFTARM = 121,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_RIGHTARM", Value=122)]
      ACT_FLINCH_RIGHTARM = 122,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_LEFTLEG", Value=123)]
      ACT_FLINCH_LEFTLEG = 123,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_RIGHTLEG", Value=124)]
      ACT_FLINCH_RIGHTLEG = 124,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_PHYSICS", Value=125)]
      ACT_FLINCH_PHYSICS = 125,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_HEAD_BACK", Value=126)]
      ACT_FLINCH_HEAD_BACK = 126,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_CHEST_BACK", Value=127)]
      ACT_FLINCH_CHEST_BACK = 127,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_STOMACH_BACK", Value=128)]
      ACT_FLINCH_STOMACH_BACK = 128,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_CROUCH_FRONT", Value=129)]
      ACT_FLINCH_CROUCH_FRONT = 129,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_CROUCH_BACK", Value=130)]
      ACT_FLINCH_CROUCH_BACK = 130,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_CROUCH_LEFT", Value=131)]
      ACT_FLINCH_CROUCH_LEFT = 131,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_FLINCH_CROUCH_RIGHT", Value=132)]
      ACT_FLINCH_CROUCH_RIGHT = 132,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_ON_FIRE", Value=133)]
      ACT_IDLE_ON_FIRE = 133,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_ON_FIRE", Value=134)]
      ACT_WALK_ON_FIRE = 134,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_ON_FIRE", Value=135)]
      ACT_RUN_ON_FIRE = 135,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RAPPEL_LOOP", Value=136)]
      ACT_RAPPEL_LOOP = 136,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_180_LEFT", Value=137)]
      ACT_180_LEFT = 137,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_180_RIGHT", Value=138)]
      ACT_180_RIGHT = 138,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_90_LEFT", Value=139)]
      ACT_90_LEFT = 139,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_90_RIGHT", Value=140)]
      ACT_90_RIGHT = 140,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_STEP_LEFT", Value=141)]
      ACT_STEP_LEFT = 141,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_STEP_RIGHT", Value=142)]
      ACT_STEP_RIGHT = 142,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_STEP_BACK", Value=143)]
      ACT_STEP_BACK = 143,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_STEP_FORE", Value=144)]
      ACT_STEP_FORE = 144,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK1", Value=145)]
      ACT_GESTURE_RANGE_ATTACK1 = 145,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK2", Value=146)]
      ACT_GESTURE_RANGE_ATTACK2 = 146,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_MELEE_ATTACK1", Value=147)]
      ACT_GESTURE_MELEE_ATTACK1 = 147,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_MELEE_ATTACK2", Value=148)]
      ACT_GESTURE_MELEE_ATTACK2 = 148,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK1_LOW", Value=149)]
      ACT_GESTURE_RANGE_ATTACK1_LOW = 149,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK2_LOW", Value=150)]
      ACT_GESTURE_RANGE_ATTACK2_LOW = 150,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_MELEE_ATTACK_SWING_GESTURE", Value=151)]
      ACT_MELEE_ATTACK_SWING_GESTURE = 151,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_SMALL_FLINCH", Value=152)]
      ACT_GESTURE_SMALL_FLINCH = 152,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_BIG_FLINCH", Value=153)]
      ACT_GESTURE_BIG_FLINCH = 153,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_BLAST", Value=154)]
      ACT_GESTURE_FLINCH_BLAST = 154,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_BLAST_SHOTGUN", Value=155)]
      ACT_GESTURE_FLINCH_BLAST_SHOTGUN = 155,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_BLAST_DAMAGED", Value=156)]
      ACT_GESTURE_FLINCH_BLAST_DAMAGED = 156,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_BLAST_DAMAGED_SHOTGUN", Value=157)]
      ACT_GESTURE_FLINCH_BLAST_DAMAGED_SHOTGUN = 157,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_HEAD", Value=158)]
      ACT_GESTURE_FLINCH_HEAD = 158,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_CHEST", Value=159)]
      ACT_GESTURE_FLINCH_CHEST = 159,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_STOMACH", Value=160)]
      ACT_GESTURE_FLINCH_STOMACH = 160,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_LEFTARM", Value=161)]
      ACT_GESTURE_FLINCH_LEFTARM = 161,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_RIGHTARM", Value=162)]
      ACT_GESTURE_FLINCH_RIGHTARM = 162,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_LEFTLEG", Value=163)]
      ACT_GESTURE_FLINCH_LEFTLEG = 163,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_FLINCH_RIGHTLEG", Value=164)]
      ACT_GESTURE_FLINCH_RIGHTLEG = 164,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_LEFT", Value=165)]
      ACT_GESTURE_TURN_LEFT = 165,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_RIGHT", Value=166)]
      ACT_GESTURE_TURN_RIGHT = 166,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_LEFT45", Value=167)]
      ACT_GESTURE_TURN_LEFT45 = 167,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_RIGHT45", Value=168)]
      ACT_GESTURE_TURN_RIGHT45 = 168,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_LEFT90", Value=169)]
      ACT_GESTURE_TURN_LEFT90 = 169,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_RIGHT90", Value=170)]
      ACT_GESTURE_TURN_RIGHT90 = 170,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_LEFT45_FLAT", Value=171)]
      ACT_GESTURE_TURN_LEFT45_FLAT = 171,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_RIGHT45_FLAT", Value=172)]
      ACT_GESTURE_TURN_RIGHT45_FLAT = 172,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_LEFT90_FLAT", Value=173)]
      ACT_GESTURE_TURN_LEFT90_FLAT = 173,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_TURN_RIGHT90_FLAT", Value=174)]
      ACT_GESTURE_TURN_RIGHT90_FLAT = 174,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BARNACLE_HIT", Value=175)]
      ACT_BARNACLE_HIT = 175,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BARNACLE_PULL", Value=176)]
      ACT_BARNACLE_PULL = 176,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BARNACLE_CHOMP", Value=177)]
      ACT_BARNACLE_CHOMP = 177,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BARNACLE_CHEW", Value=178)]
      ACT_BARNACLE_CHEW = 178,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DO_NOT_DISTURB", Value=179)]
      ACT_DO_NOT_DISTURB = 179,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SPECIFIC_SEQUENCE", Value=180)]
      ACT_SPECIFIC_SEQUENCE = 180,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_DRAW", Value=181)]
      ACT_VM_DRAW = 181,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_HOLSTER", Value=182)]
      ACT_VM_HOLSTER = 182,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_IDLE", Value=183)]
      ACT_VM_IDLE = 183,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_FIDGET", Value=184)]
      ACT_VM_FIDGET = 184,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_PULLBACK", Value=185)]
      ACT_VM_PULLBACK = 185,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_PULLBACK_HIGH", Value=186)]
      ACT_VM_PULLBACK_HIGH = 186,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_PULLBACK_LOW", Value=187)]
      ACT_VM_PULLBACK_LOW = 187,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_THROW", Value=188)]
      ACT_VM_THROW = 188,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_PULLPIN", Value=189)]
      ACT_VM_PULLPIN = 189,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_PRIMARYATTACK", Value=190)]
      ACT_VM_PRIMARYATTACK = 190,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_SECONDARYATTACK", Value=191)]
      ACT_VM_SECONDARYATTACK = 191,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_RELOAD", Value=192)]
      ACT_VM_RELOAD = 192,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_DRYFIRE", Value=193)]
      ACT_VM_DRYFIRE = 193,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_HITLEFT", Value=194)]
      ACT_VM_HITLEFT = 194,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_HITLEFT2", Value=195)]
      ACT_VM_HITLEFT2 = 195,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_HITRIGHT", Value=196)]
      ACT_VM_HITRIGHT = 196,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_HITRIGHT2", Value=197)]
      ACT_VM_HITRIGHT2 = 197,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_HITCENTER", Value=198)]
      ACT_VM_HITCENTER = 198,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_HITCENTER2", Value=199)]
      ACT_VM_HITCENTER2 = 199,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_MISSLEFT", Value=200)]
      ACT_VM_MISSLEFT = 200,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_MISSLEFT2", Value=201)]
      ACT_VM_MISSLEFT2 = 201,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_MISSRIGHT", Value=202)]
      ACT_VM_MISSRIGHT = 202,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_MISSRIGHT2", Value=203)]
      ACT_VM_MISSRIGHT2 = 203,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_MISSCENTER", Value=204)]
      ACT_VM_MISSCENTER = 204,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_MISSCENTER2", Value=205)]
      ACT_VM_MISSCENTER2 = 205,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_HAULBACK", Value=206)]
      ACT_VM_HAULBACK = 206,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_SWINGHARD", Value=207)]
      ACT_VM_SWINGHARD = 207,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_SWINGMISS", Value=208)]
      ACT_VM_SWINGMISS = 208,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_SWINGHIT", Value=209)]
      ACT_VM_SWINGHIT = 209,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_IDLE_TO_LOWERED", Value=210)]
      ACT_VM_IDLE_TO_LOWERED = 210,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_IDLE_LOWERED", Value=211)]
      ACT_VM_IDLE_LOWERED = 211,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_LOWERED_TO_IDLE", Value=212)]
      ACT_VM_LOWERED_TO_IDLE = 212,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_RECOIL1", Value=213)]
      ACT_VM_RECOIL1 = 213,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_RECOIL2", Value=214)]
      ACT_VM_RECOIL2 = 214,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_RECOIL3", Value=215)]
      ACT_VM_RECOIL3 = 215,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_PICKUP", Value=216)]
      ACT_VM_PICKUP = 216,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_RELEASE", Value=217)]
      ACT_VM_RELEASE = 217,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_ATTACH_SILENCER", Value=218)]
      ACT_VM_ATTACH_SILENCER = 218,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_VM_DETACH_SILENCER", Value=219)]
      ACT_VM_DETACH_SILENCER = 219,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_IDLE", Value=220)]
      ACT_SLAM_STICKWALL_IDLE = 220,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_ND_IDLE", Value=221)]
      ACT_SLAM_STICKWALL_ND_IDLE = 221,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_ATTACH", Value=222)]
      ACT_SLAM_STICKWALL_ATTACH = 222,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_ATTACH2", Value=223)]
      ACT_SLAM_STICKWALL_ATTACH2 = 223,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_ND_ATTACH", Value=224)]
      ACT_SLAM_STICKWALL_ND_ATTACH = 224,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_ND_ATTACH2", Value=225)]
      ACT_SLAM_STICKWALL_ND_ATTACH2 = 225,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_DETONATE", Value=226)]
      ACT_SLAM_STICKWALL_DETONATE = 226,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_DETONATOR_HOLSTER", Value=227)]
      ACT_SLAM_STICKWALL_DETONATOR_HOLSTER = 227,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_DRAW", Value=228)]
      ACT_SLAM_STICKWALL_DRAW = 228,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_ND_DRAW", Value=229)]
      ACT_SLAM_STICKWALL_ND_DRAW = 229,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_TO_THROW", Value=230)]
      ACT_SLAM_STICKWALL_TO_THROW = 230,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_TO_THROW_ND", Value=231)]
      ACT_SLAM_STICKWALL_TO_THROW_ND = 231,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_STICKWALL_TO_TRIPMINE_ND", Value=232)]
      ACT_SLAM_STICKWALL_TO_TRIPMINE_ND = 232,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_IDLE", Value=233)]
      ACT_SLAM_THROW_IDLE = 233,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_ND_IDLE", Value=234)]
      ACT_SLAM_THROW_ND_IDLE = 234,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_THROW", Value=235)]
      ACT_SLAM_THROW_THROW = 235,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_THROW2", Value=236)]
      ACT_SLAM_THROW_THROW2 = 236,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_THROW_ND", Value=237)]
      ACT_SLAM_THROW_THROW_ND = 237,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_THROW_ND2", Value=238)]
      ACT_SLAM_THROW_THROW_ND2 = 238,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_DRAW", Value=239)]
      ACT_SLAM_THROW_DRAW = 239,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_ND_DRAW", Value=240)]
      ACT_SLAM_THROW_ND_DRAW = 240,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_TO_STICKWALL", Value=241)]
      ACT_SLAM_THROW_TO_STICKWALL = 241,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_TO_STICKWALL_ND", Value=242)]
      ACT_SLAM_THROW_TO_STICKWALL_ND = 242,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_DETONATE", Value=243)]
      ACT_SLAM_THROW_DETONATE = 243,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_DETONATOR_HOLSTER", Value=244)]
      ACT_SLAM_THROW_DETONATOR_HOLSTER = 244,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_THROW_TO_TRIPMINE_ND", Value=245)]
      ACT_SLAM_THROW_TO_TRIPMINE_ND = 245,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_TRIPMINE_IDLE", Value=246)]
      ACT_SLAM_TRIPMINE_IDLE = 246,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_TRIPMINE_DRAW", Value=247)]
      ACT_SLAM_TRIPMINE_DRAW = 247,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_TRIPMINE_ATTACH", Value=248)]
      ACT_SLAM_TRIPMINE_ATTACH = 248,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_TRIPMINE_ATTACH2", Value=249)]
      ACT_SLAM_TRIPMINE_ATTACH2 = 249,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_TRIPMINE_TO_STICKWALL_ND", Value=250)]
      ACT_SLAM_TRIPMINE_TO_STICKWALL_ND = 250,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_TRIPMINE_TO_THROW_ND", Value=251)]
      ACT_SLAM_TRIPMINE_TO_THROW_ND = 251,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_DETONATOR_IDLE", Value=252)]
      ACT_SLAM_DETONATOR_IDLE = 252,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_DETONATOR_DRAW", Value=253)]
      ACT_SLAM_DETONATOR_DRAW = 253,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_DETONATOR_DETONATE", Value=254)]
      ACT_SLAM_DETONATOR_DETONATE = 254,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_DETONATOR_HOLSTER", Value=255)]
      ACT_SLAM_DETONATOR_HOLSTER = 255,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_DETONATOR_STICKWALL_DRAW", Value=256)]
      ACT_SLAM_DETONATOR_STICKWALL_DRAW = 256,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SLAM_DETONATOR_THROW_DRAW", Value=257)]
      ACT_SLAM_DETONATOR_THROW_DRAW = 257,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SHOTGUN_RELOAD_START", Value=258)]
      ACT_SHOTGUN_RELOAD_START = 258,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SHOTGUN_RELOAD_FINISH", Value=259)]
      ACT_SHOTGUN_RELOAD_FINISH = 259,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SHOTGUN_PUMP", Value=260)]
      ACT_SHOTGUN_PUMP = 260,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SMG2_IDLE2", Value=261)]
      ACT_SMG2_IDLE2 = 261,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SMG2_FIRE2", Value=262)]
      ACT_SMG2_FIRE2 = 262,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SMG2_DRAW2", Value=263)]
      ACT_SMG2_DRAW2 = 263,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SMG2_RELOAD2", Value=264)]
      ACT_SMG2_RELOAD2 = 264,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SMG2_DRYFIRE2", Value=265)]
      ACT_SMG2_DRYFIRE2 = 265,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SMG2_TOAUTO", Value=266)]
      ACT_SMG2_TOAUTO = 266,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_SMG2_TOBURST", Value=267)]
      ACT_SMG2_TOBURST = 267,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_PHYSCANNON_UPGRADE", Value=268)]
      ACT_PHYSCANNON_UPGRADE = 268,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_AR1", Value=269)]
      ACT_RANGE_ATTACK_AR1 = 269,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_AR2", Value=270)]
      ACT_RANGE_ATTACK_AR2 = 270,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_AR2_LOW", Value=271)]
      ACT_RANGE_ATTACK_AR2_LOW = 271,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_AR2_GRENADE", Value=272)]
      ACT_RANGE_ATTACK_AR2_GRENADE = 272,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_HMG1", Value=273)]
      ACT_RANGE_ATTACK_HMG1 = 273,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_ML", Value=274)]
      ACT_RANGE_ATTACK_ML = 274,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_SMG1", Value=275)]
      ACT_RANGE_ATTACK_SMG1 = 275,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_SMG1_LOW", Value=276)]
      ACT_RANGE_ATTACK_SMG1_LOW = 276,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_SMG2", Value=277)]
      ACT_RANGE_ATTACK_SMG2 = 277,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_SHOTGUN", Value=278)]
      ACT_RANGE_ATTACK_SHOTGUN = 278,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_SHOTGUN_LOW", Value=279)]
      ACT_RANGE_ATTACK_SHOTGUN_LOW = 279,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_PISTOL", Value=280)]
      ACT_RANGE_ATTACK_PISTOL = 280,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_PISTOL_LOW", Value=281)]
      ACT_RANGE_ATTACK_PISTOL_LOW = 281,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_SLAM", Value=282)]
      ACT_RANGE_ATTACK_SLAM = 282,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_TRIPWIRE", Value=283)]
      ACT_RANGE_ATTACK_TRIPWIRE = 283,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_THROW", Value=284)]
      ACT_RANGE_ATTACK_THROW = 284,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_SNIPER_RIFLE", Value=285)]
      ACT_RANGE_ATTACK_SNIPER_RIFLE = 285,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_ATTACK_RPG", Value=286)]
      ACT_RANGE_ATTACK_RPG = 286,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_MELEE_ATTACK_SWING", Value=287)]
      ACT_MELEE_ATTACK_SWING = 287,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_AIM_LOW", Value=288)]
      ACT_RANGE_AIM_LOW = 288,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_AIM_SMG1_LOW", Value=289)]
      ACT_RANGE_AIM_SMG1_LOW = 289,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_AIM_PISTOL_LOW", Value=290)]
      ACT_RANGE_AIM_PISTOL_LOW = 290,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RANGE_AIM_AR2_LOW", Value=291)]
      ACT_RANGE_AIM_AR2_LOW = 291,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_COVER_PISTOL_LOW", Value=292)]
      ACT_COVER_PISTOL_LOW = 292,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_COVER_SMG1_LOW", Value=293)]
      ACT_COVER_SMG1_LOW = 293,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_AR1", Value=294)]
      ACT_GESTURE_RANGE_ATTACK_AR1 = 294,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_AR2", Value=295)]
      ACT_GESTURE_RANGE_ATTACK_AR2 = 295,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_AR2_GRENADE", Value=296)]
      ACT_GESTURE_RANGE_ATTACK_AR2_GRENADE = 296,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_HMG1", Value=297)]
      ACT_GESTURE_RANGE_ATTACK_HMG1 = 297,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_ML", Value=298)]
      ACT_GESTURE_RANGE_ATTACK_ML = 298,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_SMG1", Value=299)]
      ACT_GESTURE_RANGE_ATTACK_SMG1 = 299,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_SMG1_LOW", Value=300)]
      ACT_GESTURE_RANGE_ATTACK_SMG1_LOW = 300,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_SMG2", Value=301)]
      ACT_GESTURE_RANGE_ATTACK_SMG2 = 301,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_SHOTGUN", Value=302)]
      ACT_GESTURE_RANGE_ATTACK_SHOTGUN = 302,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_PISTOL", Value=303)]
      ACT_GESTURE_RANGE_ATTACK_PISTOL = 303,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_PISTOL_LOW", Value=304)]
      ACT_GESTURE_RANGE_ATTACK_PISTOL_LOW = 304,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_SLAM", Value=305)]
      ACT_GESTURE_RANGE_ATTACK_SLAM = 305,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_TRIPWIRE", Value=306)]
      ACT_GESTURE_RANGE_ATTACK_TRIPWIRE = 306,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_THROW", Value=307)]
      ACT_GESTURE_RANGE_ATTACK_THROW = 307,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RANGE_ATTACK_SNIPER_RIFLE", Value=308)]
      ACT_GESTURE_RANGE_ATTACK_SNIPER_RIFLE = 308,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_MELEE_ATTACK_SWING", Value=309)]
      ACT_GESTURE_MELEE_ATTACK_SWING = 309,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_RIFLE", Value=310)]
      ACT_IDLE_RIFLE = 310,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_SMG1", Value=311)]
      ACT_IDLE_SMG1 = 311,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_ANGRY_SMG1", Value=312)]
      ACT_IDLE_ANGRY_SMG1 = 312,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_PISTOL", Value=313)]
      ACT_IDLE_PISTOL = 313,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_ANGRY_PISTOL", Value=314)]
      ACT_IDLE_ANGRY_PISTOL = 314,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_ANGRY_SHOTGUN", Value=315)]
      ACT_IDLE_ANGRY_SHOTGUN = 315,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_STEALTH_PISTOL", Value=316)]
      ACT_IDLE_STEALTH_PISTOL = 316,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_PACKAGE", Value=317)]
      ACT_IDLE_PACKAGE = 317,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_PACKAGE", Value=318)]
      ACT_WALK_PACKAGE = 318,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_SUITCASE", Value=319)]
      ACT_IDLE_SUITCASE = 319,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_SUITCASE", Value=320)]
      ACT_WALK_SUITCASE = 320,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_SMG1_RELAXED", Value=321)]
      ACT_IDLE_SMG1_RELAXED = 321,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_SMG1_STIMULATED", Value=322)]
      ACT_IDLE_SMG1_STIMULATED = 322,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_RIFLE_RELAXED", Value=323)]
      ACT_WALK_RIFLE_RELAXED = 323,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_RIFLE_RELAXED", Value=324)]
      ACT_RUN_RIFLE_RELAXED = 324,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_RIFLE_STIMULATED", Value=325)]
      ACT_WALK_RIFLE_STIMULATED = 325,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_RIFLE_STIMULATED", Value=326)]
      ACT_RUN_RIFLE_STIMULATED = 326,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_AIM_RIFLE_STIMULATED", Value=327)]
      ACT_IDLE_AIM_RIFLE_STIMULATED = 327,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM_RIFLE_STIMULATED", Value=328)]
      ACT_WALK_AIM_RIFLE_STIMULATED = 328,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM_RIFLE_STIMULATED", Value=329)]
      ACT_RUN_AIM_RIFLE_STIMULATED = 329,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_SHOTGUN_RELAXED", Value=330)]
      ACT_IDLE_SHOTGUN_RELAXED = 330,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_SHOTGUN_STIMULATED", Value=331)]
      ACT_IDLE_SHOTGUN_STIMULATED = 331,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_SHOTGUN_AGITATED", Value=332)]
      ACT_IDLE_SHOTGUN_AGITATED = 332,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_ANGRY", Value=333)]
      ACT_WALK_ANGRY = 333,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_POLICE_HARASS1", Value=334)]
      ACT_POLICE_HARASS1 = 334,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_POLICE_HARASS2", Value=335)]
      ACT_POLICE_HARASS2 = 335,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_MANNEDGUN", Value=336)]
      ACT_IDLE_MANNEDGUN = 336,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_MELEE", Value=337)]
      ACT_IDLE_MELEE = 337,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_ANGRY_MELEE", Value=338)]
      ACT_IDLE_ANGRY_MELEE = 338,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_RPG_RELAXED", Value=339)]
      ACT_IDLE_RPG_RELAXED = 339,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_RPG", Value=340)]
      ACT_IDLE_RPG = 340,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_ANGRY_RPG", Value=341)]
      ACT_IDLE_ANGRY_RPG = 341,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_COVER_LOW_RPG", Value=342)]
      ACT_COVER_LOW_RPG = 342,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_RPG", Value=343)]
      ACT_WALK_RPG = 343,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_RPG", Value=344)]
      ACT_RUN_RPG = 344,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_CROUCH_RPG", Value=345)]
      ACT_WALK_CROUCH_RPG = 345,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_CROUCH_RPG", Value=346)]
      ACT_RUN_CROUCH_RPG = 346,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_RPG_RELAXED", Value=347)]
      ACT_WALK_RPG_RELAXED = 347,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_RPG_RELAXED", Value=348)]
      ACT_RUN_RPG_RELAXED = 348,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_RIFLE", Value=349)]
      ACT_WALK_RIFLE = 349,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM_RIFLE", Value=350)]
      ACT_WALK_AIM_RIFLE = 350,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_CROUCH_RIFLE", Value=351)]
      ACT_WALK_CROUCH_RIFLE = 351,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_CROUCH_AIM_RIFLE", Value=352)]
      ACT_WALK_CROUCH_AIM_RIFLE = 352,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_RIFLE", Value=353)]
      ACT_RUN_RIFLE = 353,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM_RIFLE", Value=354)]
      ACT_RUN_AIM_RIFLE = 354,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_CROUCH_RIFLE", Value=355)]
      ACT_RUN_CROUCH_RIFLE = 355,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_CROUCH_AIM_RIFLE", Value=356)]
      ACT_RUN_CROUCH_AIM_RIFLE = 356,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_STEALTH_PISTOL", Value=357)]
      ACT_RUN_STEALTH_PISTOL = 357,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM_SHOTGUN", Value=358)]
      ACT_WALK_AIM_SHOTGUN = 358,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM_SHOTGUN", Value=359)]
      ACT_RUN_AIM_SHOTGUN = 359,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_PISTOL", Value=360)]
      ACT_WALK_PISTOL = 360,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_PISTOL", Value=361)]
      ACT_RUN_PISTOL = 361,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM_PISTOL", Value=362)]
      ACT_WALK_AIM_PISTOL = 362,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM_PISTOL", Value=363)]
      ACT_RUN_AIM_PISTOL = 363,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_STEALTH_PISTOL", Value=364)]
      ACT_WALK_STEALTH_PISTOL = 364,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_AIM_STEALTH_PISTOL", Value=365)]
      ACT_WALK_AIM_STEALTH_PISTOL = 365,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RUN_AIM_STEALTH_PISTOL", Value=366)]
      ACT_RUN_AIM_STEALTH_PISTOL = 366,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD_PISTOL", Value=367)]
      ACT_RELOAD_PISTOL = 367,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD_PISTOL_LOW", Value=368)]
      ACT_RELOAD_PISTOL_LOW = 368,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD_SMG1", Value=369)]
      ACT_RELOAD_SMG1 = 369,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD_SMG1_LOW", Value=370)]
      ACT_RELOAD_SMG1_LOW = 370,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD_SHOTGUN", Value=371)]
      ACT_RELOAD_SHOTGUN = 371,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_RELOAD_SHOTGUN_LOW", Value=372)]
      ACT_RELOAD_SHOTGUN_LOW = 372,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RELOAD", Value=373)]
      ACT_GESTURE_RELOAD = 373,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RELOAD_PISTOL", Value=374)]
      ACT_GESTURE_RELOAD_PISTOL = 374,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RELOAD_SMG1", Value=375)]
      ACT_GESTURE_RELOAD_SMG1 = 375,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_RELOAD_SHOTGUN", Value=376)]
      ACT_GESTURE_RELOAD_SHOTGUN = 376,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_LEAN_LEFT", Value=377)]
      ACT_BUSY_LEAN_LEFT = 377,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_LEAN_LEFT_ENTRY", Value=378)]
      ACT_BUSY_LEAN_LEFT_ENTRY = 378,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_LEAN_LEFT_EXIT", Value=379)]
      ACT_BUSY_LEAN_LEFT_EXIT = 379,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_LEAN_BACK", Value=380)]
      ACT_BUSY_LEAN_BACK = 380,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_LEAN_BACK_ENTRY", Value=381)]
      ACT_BUSY_LEAN_BACK_ENTRY = 381,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_LEAN_BACK_EXIT", Value=382)]
      ACT_BUSY_LEAN_BACK_EXIT = 382,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_SIT_GROUND", Value=383)]
      ACT_BUSY_SIT_GROUND = 383,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_SIT_GROUND_ENTRY", Value=384)]
      ACT_BUSY_SIT_GROUND_ENTRY = 384,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_SIT_GROUND_EXIT", Value=385)]
      ACT_BUSY_SIT_GROUND_EXIT = 385,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_SIT_CHAIR", Value=386)]
      ACT_BUSY_SIT_CHAIR = 386,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_SIT_CHAIR_ENTRY", Value=387)]
      ACT_BUSY_SIT_CHAIR_ENTRY = 387,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_SIT_CHAIR_EXIT", Value=388)]
      ACT_BUSY_SIT_CHAIR_EXIT = 388,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_STAND", Value=389)]
      ACT_BUSY_STAND = 389,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_BUSY_QUEUE", Value=390)]
      ACT_BUSY_QUEUE = 390,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DUCK_DODGE", Value=391)]
      ACT_DUCK_DODGE = 391,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIE_BARNACLE_SWALLOW", Value=392)]
      ACT_DIE_BARNACLE_SWALLOW = 392,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_GESTURE_BARNACLE_STRANGLE", Value=393)]
      ACT_GESTURE_BARNACLE_STRANGLE = 393,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_PHYSCANNON_DETACH", Value=394)]
      ACT_PHYSCANNON_DETACH = 394,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_PHYSCANNON_ANIMATE", Value=395)]
      ACT_PHYSCANNON_ANIMATE = 395,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_PHYSCANNON_ANIMATE_PRE", Value=396)]
      ACT_PHYSCANNON_ANIMATE_PRE = 396,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_PHYSCANNON_ANIMATE_POST", Value=397)]
      ACT_PHYSCANNON_ANIMATE_POST = 397,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIE_FRONTSIDE", Value=398)]
      ACT_DIE_FRONTSIDE = 398,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIE_RIGHTSIDE", Value=399)]
      ACT_DIE_RIGHTSIDE = 399,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIE_BACKSIDE", Value=400)]
      ACT_DIE_BACKSIDE = 400,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DIE_LEFTSIDE", Value=401)]
      ACT_DIE_LEFTSIDE = 401,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_OPEN_DOOR", Value=402)]
      ACT_OPEN_DOOR = 402,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DI_ALYX_ZOMBIE_MELEE", Value=403)]
      ACT_DI_ALYX_ZOMBIE_MELEE = 403,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DI_ALYX_ZOMBIE_TORSO_MELEE", Value=404)]
      ACT_DI_ALYX_ZOMBIE_TORSO_MELEE = 404,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DI_ALYX_HEADCRAB_MELEE", Value=405)]
      ACT_DI_ALYX_HEADCRAB_MELEE = 405,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DI_ALYX_ANTLION", Value=406)]
      ACT_DI_ALYX_ANTLION = 406,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DI_ALYX_ZOMBIE_SHOTGUN64", Value=407)]
      ACT_DI_ALYX_ZOMBIE_SHOTGUN64 = 407,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DI_ALYX_ZOMBIE_SHOTGUN26", Value=408)]
      ACT_DI_ALYX_ZOMBIE_SHOTGUN26 = 408,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_READINESS_RELAXED_TO_STIMULATED", Value=409)]
      ACT_READINESS_RELAXED_TO_STIMULATED = 409,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_READINESS_RELAXED_TO_STIMULATED_WALK", Value=410)]
      ACT_READINESS_RELAXED_TO_STIMULATED_WALK = 410,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_READINESS_AGITATED_TO_STIMULATED", Value=411)]
      ACT_READINESS_AGITATED_TO_STIMULATED = 411,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_READINESS_STIMULATED_TO_RELAXED", Value=412)]
      ACT_READINESS_STIMULATED_TO_RELAXED = 412,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_READINESS_PISTOL_RELAXED_TO_STIMULATED", Value=413)]
      ACT_READINESS_PISTOL_RELAXED_TO_STIMULATED = 413,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_READINESS_PISTOL_RELAXED_TO_STIMULATED_WALK", Value=414)]
      ACT_READINESS_PISTOL_RELAXED_TO_STIMULATED_WALK = 414,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_READINESS_PISTOL_AGITATED_TO_STIMULATED", Value=415)]
      ACT_READINESS_PISTOL_AGITATED_TO_STIMULATED = 415,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_READINESS_PISTOL_STIMULATED_TO_RELAXED", Value=416)]
      ACT_READINESS_PISTOL_STIMULATED_TO_RELAXED = 416,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_IDLE_CARRY", Value=417)]
      ACT_IDLE_CARRY = 417,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WALK_CARRY", Value=418)]
      ACT_WALK_CARRY = 418,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_IDLE", Value=419)]
      ACT_DOTA_IDLE = 419,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_IDLE_RARE", Value=421)]
      ACT_DOTA_IDLE_RARE = 421,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RUN", Value=422)]
      ACT_DOTA_RUN = 422,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ATTACK", Value=424)]
      ACT_DOTA_ATTACK = 424,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ATTACK2", Value=425)]
      ACT_DOTA_ATTACK2 = 425,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ATTACK_EVENT", Value=426)]
      ACT_DOTA_ATTACK_EVENT = 426,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_DIE", Value=427)]
      ACT_DOTA_DIE = 427,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_FLINCH", Value=428)]
      ACT_DOTA_FLINCH = 428,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_FLAIL", Value=429)]
      ACT_DOTA_FLAIL = 429,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_DISABLED", Value=430)]
      ACT_DOTA_DISABLED = 430,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_1", Value=431)]
      ACT_DOTA_CAST_ABILITY_1 = 431,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_2", Value=432)]
      ACT_DOTA_CAST_ABILITY_2 = 432,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_3", Value=433)]
      ACT_DOTA_CAST_ABILITY_3 = 433,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_4", Value=434)]
      ACT_DOTA_CAST_ABILITY_4 = 434,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_5", Value=435)]
      ACT_DOTA_CAST_ABILITY_5 = 435,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_6", Value=436)]
      ACT_DOTA_CAST_ABILITY_6 = 436,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_OVERRIDE_ABILITY_1", Value=437)]
      ACT_DOTA_OVERRIDE_ABILITY_1 = 437,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_OVERRIDE_ABILITY_2", Value=438)]
      ACT_DOTA_OVERRIDE_ABILITY_2 = 438,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_OVERRIDE_ABILITY_3", Value=439)]
      ACT_DOTA_OVERRIDE_ABILITY_3 = 439,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_OVERRIDE_ABILITY_4", Value=440)]
      ACT_DOTA_OVERRIDE_ABILITY_4 = 440,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_ABILITY_1", Value=441)]
      ACT_DOTA_CHANNEL_ABILITY_1 = 441,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_ABILITY_2", Value=442)]
      ACT_DOTA_CHANNEL_ABILITY_2 = 442,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_ABILITY_3", Value=443)]
      ACT_DOTA_CHANNEL_ABILITY_3 = 443,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_ABILITY_4", Value=444)]
      ACT_DOTA_CHANNEL_ABILITY_4 = 444,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_ABILITY_5", Value=445)]
      ACT_DOTA_CHANNEL_ABILITY_5 = 445,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_ABILITY_6", Value=446)]
      ACT_DOTA_CHANNEL_ABILITY_6 = 446,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_END_ABILITY_1", Value=447)]
      ACT_DOTA_CHANNEL_END_ABILITY_1 = 447,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_END_ABILITY_2", Value=448)]
      ACT_DOTA_CHANNEL_END_ABILITY_2 = 448,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_END_ABILITY_3", Value=449)]
      ACT_DOTA_CHANNEL_END_ABILITY_3 = 449,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_END_ABILITY_4", Value=450)]
      ACT_DOTA_CHANNEL_END_ABILITY_4 = 450,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_END_ABILITY_5", Value=451)]
      ACT_DOTA_CHANNEL_END_ABILITY_5 = 451,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_END_ABILITY_6", Value=452)]
      ACT_DOTA_CHANNEL_END_ABILITY_6 = 452,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CONSTANT_LAYER", Value=453)]
      ACT_DOTA_CONSTANT_LAYER = 453,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAPTURE", Value=454)]
      ACT_DOTA_CAPTURE = 454,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SPAWN", Value=455)]
      ACT_DOTA_SPAWN = 455,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_KILLTAUNT", Value=456)]
      ACT_DOTA_KILLTAUNT = 456,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_TAUNT", Value=457)]
      ACT_DOTA_TAUNT = 457,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_THIRST", Value=458)]
      ACT_DOTA_THIRST = 458,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_DRAGONBREATH", Value=459)]
      ACT_DOTA_CAST_DRAGONBREATH = 459,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ECHO_SLAM", Value=460)]
      ACT_DOTA_ECHO_SLAM = 460,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_1_END", Value=461)]
      ACT_DOTA_CAST_ABILITY_1_END = 461,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_2_END", Value=462)]
      ACT_DOTA_CAST_ABILITY_2_END = 462,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_3_END", Value=463)]
      ACT_DOTA_CAST_ABILITY_3_END = 463,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_4_END", Value=464)]
      ACT_DOTA_CAST_ABILITY_4_END = 464,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_MIRANA_LEAP_END", Value=465)]
      ACT_MIRANA_LEAP_END = 465,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WAVEFORM_START", Value=466)]
      ACT_WAVEFORM_START = 466,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_WAVEFORM_END", Value=467)]
      ACT_WAVEFORM_END = 467,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_ROT", Value=468)]
      ACT_DOTA_CAST_ABILITY_ROT = 468,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_DIE_SPECIAL", Value=469)]
      ACT_DOTA_DIE_SPECIAL = 469,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RATTLETRAP_BATTERYASSAULT", Value=470)]
      ACT_DOTA_RATTLETRAP_BATTERYASSAULT = 470,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RATTLETRAP_POWERCOGS", Value=471)]
      ACT_DOTA_RATTLETRAP_POWERCOGS = 471,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RATTLETRAP_HOOKSHOT_START", Value=472)]
      ACT_DOTA_RATTLETRAP_HOOKSHOT_START = 472,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RATTLETRAP_HOOKSHOT_LOOP", Value=473)]
      ACT_DOTA_RATTLETRAP_HOOKSHOT_LOOP = 473,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RATTLETRAP_HOOKSHOT_END", Value=474)]
      ACT_DOTA_RATTLETRAP_HOOKSHOT_END = 474,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_STORM_SPIRIT_OVERLOAD_RUN_OVERRIDE", Value=475)]
      ACT_STORM_SPIRIT_OVERLOAD_RUN_OVERRIDE = 475,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_TINKER_REARM1", Value=476)]
      ACT_DOTA_TINKER_REARM1 = 476,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_TINKER_REARM2", Value=477)]
      ACT_DOTA_TINKER_REARM2 = 477,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_TINKER_REARM3", Value=478)]
      ACT_DOTA_TINKER_REARM3 = 478,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_TINY_AVALANCHE", Value=479)]
      ACT_TINY_AVALANCHE = 479,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_TINY_TOSS", Value=480)]
      ACT_TINY_TOSS = 480,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_TINY_GROWL", Value=481)]
      ACT_TINY_GROWL = 481,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_WEAVERBUG_ATTACH", Value=482)]
      ACT_DOTA_WEAVERBUG_ATTACH = 482,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_WILD_AXES_END", Value=483)]
      ACT_DOTA_CAST_WILD_AXES_END = 483,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_LIFE_BREAK_START", Value=484)]
      ACT_DOTA_CAST_LIFE_BREAK_START = 484,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_LIFE_BREAK_END", Value=485)]
      ACT_DOTA_CAST_LIFE_BREAK_END = 485,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_NIGHTSTALKER_TRANSITION", Value=486)]
      ACT_DOTA_NIGHTSTALKER_TRANSITION = 486,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_LIFESTEALER_RAGE", Value=487)]
      ACT_DOTA_LIFESTEALER_RAGE = 487,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_LIFESTEALER_OPEN_WOUNDS", Value=488)]
      ACT_DOTA_LIFESTEALER_OPEN_WOUNDS = 488,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SAND_KING_BURROW_IN", Value=489)]
      ACT_DOTA_SAND_KING_BURROW_IN = 489,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SAND_KING_BURROW_OUT", Value=490)]
      ACT_DOTA_SAND_KING_BURROW_OUT = 490,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_EARTHSHAKER_TOTEM_ATTACK", Value=491)]
      ACT_DOTA_EARTHSHAKER_TOTEM_ATTACK = 491,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_WHEEL_LAYER", Value=492)]
      ACT_DOTA_WHEEL_LAYER = 492,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ALCHEMIST_CHEMICAL_RAGE_START", Value=493)]
      ACT_DOTA_ALCHEMIST_CHEMICAL_RAGE_START = 493,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ALCHEMIST_CONCOCTION", Value=494)]
      ACT_DOTA_ALCHEMIST_CONCOCTION = 494,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_JAKIRO_LIQUIDFIRE_START", Value=495)]
      ACT_DOTA_JAKIRO_LIQUIDFIRE_START = 495,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_JAKIRO_LIQUIDFIRE_LOOP", Value=496)]
      ACT_DOTA_JAKIRO_LIQUIDFIRE_LOOP = 496,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_LIFESTEALER_INFEST", Value=497)]
      ACT_DOTA_LIFESTEALER_INFEST = 497,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_LIFESTEALER_INFEST_END", Value=498)]
      ACT_DOTA_LIFESTEALER_INFEST_END = 498,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_LASSO_LOOP", Value=499)]
      ACT_DOTA_LASSO_LOOP = 499,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ALCHEMIST_CONCOCTION_THROW", Value=500)]
      ACT_DOTA_ALCHEMIST_CONCOCTION_THROW = 500,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ALCHEMIST_CHEMICAL_RAGE_END", Value=501)]
      ACT_DOTA_ALCHEMIST_CHEMICAL_RAGE_END = 501,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_COLD_SNAP", Value=502)]
      ACT_DOTA_CAST_COLD_SNAP = 502,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_GHOST_WALK", Value=503)]
      ACT_DOTA_CAST_GHOST_WALK = 503,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_TORNADO", Value=504)]
      ACT_DOTA_CAST_TORNADO = 504,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_EMP", Value=505)]
      ACT_DOTA_CAST_EMP = 505,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ALACRITY", Value=506)]
      ACT_DOTA_CAST_ALACRITY = 506,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_CHAOS_METEOR", Value=507)]
      ACT_DOTA_CAST_CHAOS_METEOR = 507,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_SUN_STRIKE", Value=508)]
      ACT_DOTA_CAST_SUN_STRIKE = 508,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_FORGE_SPIRIT", Value=509)]
      ACT_DOTA_CAST_FORGE_SPIRIT = 509,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ICE_WALL", Value=510)]
      ACT_DOTA_CAST_ICE_WALL = 510,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_DEAFENING_BLAST", Value=511)]
      ACT_DOTA_CAST_DEAFENING_BLAST = 511,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_VICTORY", Value=512)]
      ACT_DOTA_VICTORY = 512,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_DEFEAT", Value=513)]
      ACT_DOTA_DEFEAT = 513,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SPIRIT_BREAKER_CHARGE_POSE", Value=514)]
      ACT_DOTA_SPIRIT_BREAKER_CHARGE_POSE = 514,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SPIRIT_BREAKER_CHARGE_END", Value=515)]
      ACT_DOTA_SPIRIT_BREAKER_CHARGE_END = 515,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_TELEPORT", Value=516)]
      ACT_DOTA_TELEPORT = 516,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_TELEPORT_END", Value=517)]
      ACT_DOTA_TELEPORT_END = 517,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_REFRACTION", Value=518)]
      ACT_DOTA_CAST_REFRACTION = 518,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_7", Value=519)]
      ACT_DOTA_CAST_ABILITY_7 = 519,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CANCEL_SIREN_SONG", Value=520)]
      ACT_DOTA_CANCEL_SIREN_SONG = 520,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHANNEL_ABILITY_7", Value=521)]
      ACT_DOTA_CHANNEL_ABILITY_7 = 521,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_LOADOUT", Value=522)]
      ACT_DOTA_LOADOUT = 522,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_FORCESTAFF_END", Value=523)]
      ACT_DOTA_FORCESTAFF_END = 523,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_POOF_END", Value=524)]
      ACT_DOTA_POOF_END = 524,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SLARK_POUNCE", Value=525)]
      ACT_DOTA_SLARK_POUNCE = 525,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_MAGNUS_SKEWER_START", Value=526)]
      ACT_DOTA_MAGNUS_SKEWER_START = 526,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_MAGNUS_SKEWER_END", Value=527)]
      ACT_DOTA_MAGNUS_SKEWER_END = 527,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_MEDUSA_STONE_GAZE", Value=528)]
      ACT_DOTA_MEDUSA_STONE_GAZE = 528,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RELAX_START", Value=529)]
      ACT_DOTA_RELAX_START = 529,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RELAX_LOOP", Value=530)]
      ACT_DOTA_RELAX_LOOP = 530,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RELAX_END", Value=531)]
      ACT_DOTA_RELAX_END = 531,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CENTAUR_STAMPEDE", Value=532)]
      ACT_DOTA_CENTAUR_STAMPEDE = 532,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_BELLYACHE_START", Value=533)]
      ACT_DOTA_BELLYACHE_START = 533,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_BELLYACHE_LOOP", Value=534)]
      ACT_DOTA_BELLYACHE_LOOP = 534,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_BELLYACHE_END", Value=535)]
      ACT_DOTA_BELLYACHE_END = 535,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ROQUELAIRE_LAND", Value=536)]
      ACT_DOTA_ROQUELAIRE_LAND = 536,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ROQUELAIRE_LAND_IDLE", Value=537)]
      ACT_DOTA_ROQUELAIRE_LAND_IDLE = 537,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_GREEVIL_CAST", Value=538)]
      ACT_DOTA_GREEVIL_CAST = 538,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_GREEVIL_OVERRIDE_ABILITY", Value=539)]
      ACT_DOTA_GREEVIL_OVERRIDE_ABILITY = 539,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_GREEVIL_HOOK_START", Value=540)]
      ACT_DOTA_GREEVIL_HOOK_START = 540,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_GREEVIL_HOOK_END", Value=541)]
      ACT_DOTA_GREEVIL_HOOK_END = 541,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_GREEVIL_BLINK_BONE", Value=542)]
      ACT_DOTA_GREEVIL_BLINK_BONE = 542,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_IDLE_SLEEPING", Value=543)]
      ACT_DOTA_IDLE_SLEEPING = 543,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_INTRO", Value=544)]
      ACT_DOTA_INTRO = 544,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_GESTURE_POINT", Value=545)]
      ACT_DOTA_GESTURE_POINT = 545,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_GESTURE_ACCENT", Value=546)]
      ACT_DOTA_GESTURE_ACCENT = 546,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SLEEPING_END", Value=547)]
      ACT_DOTA_SLEEPING_END = 547,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_AMBUSH", Value=548)]
      ACT_DOTA_AMBUSH = 548,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ITEM_LOOK", Value=549)]
      ACT_DOTA_ITEM_LOOK = 549,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_STARTLE", Value=550)]
      ACT_DOTA_STARTLE = 550,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_FRUSTRATION", Value=551)]
      ACT_DOTA_FRUSTRATION = 551,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_TELEPORT_REACT", Value=552)]
      ACT_DOTA_TELEPORT_REACT = 552,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_TELEPORT_END_REACT", Value=553)]
      ACT_DOTA_TELEPORT_END_REACT = 553,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SHRUG", Value=554)]
      ACT_DOTA_SHRUG = 554,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RELAX_LOOP_END", Value=555)]
      ACT_DOTA_RELAX_LOOP_END = 555,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_PRESENT_ITEM", Value=556)]
      ACT_DOTA_PRESENT_ITEM = 556,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_IDLE_IMPATIENT", Value=557)]
      ACT_DOTA_IDLE_IMPATIENT = 557,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SHARPEN_WEAPON", Value=558)]
      ACT_DOTA_SHARPEN_WEAPON = 558,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SHARPEN_WEAPON_OUT", Value=559)]
      ACT_DOTA_SHARPEN_WEAPON_OUT = 559,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_IDLE_SLEEPING_END", Value=560)]
      ACT_DOTA_IDLE_SLEEPING_END = 560,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_BRIDGE_DESTROY", Value=561)]
      ACT_DOTA_BRIDGE_DESTROY = 561,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_TAUNT_SNIPER", Value=562)]
      ACT_DOTA_TAUNT_SNIPER = 562,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_DEATH_BY_SNIPER", Value=563)]
      ACT_DOTA_DEATH_BY_SNIPER = 563,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_LOOK_AROUND", Value=564)]
      ACT_DOTA_LOOK_AROUND = 564,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAGED_CREEP_RAGE", Value=565)]
      ACT_DOTA_CAGED_CREEP_RAGE = 565,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAGED_CREEP_RAGE_OUT", Value=566)]
      ACT_DOTA_CAGED_CREEP_RAGE_OUT = 566,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAGED_CREEP_SMASH", Value=567)]
      ACT_DOTA_CAGED_CREEP_SMASH = 567,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAGED_CREEP_SMASH_OUT", Value=568)]
      ACT_DOTA_CAGED_CREEP_SMASH_OUT = 568,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_IDLE_IMPATIENT_SWORD_TAP", Value=569)]
      ACT_DOTA_IDLE_IMPATIENT_SWORD_TAP = 569,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_INTRO_LOOP", Value=570)]
      ACT_DOTA_INTRO_LOOP = 570,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_BRIDGE_THREAT", Value=571)]
      ACT_DOTA_BRIDGE_THREAT = 571,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_DAGON", Value=572)]
      ACT_DOTA_DAGON = 572,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_2_ES_ROLL_START", Value=573)]
      ACT_DOTA_CAST_ABILITY_2_ES_ROLL_START = 573,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_2_ES_ROLL", Value=574)]
      ACT_DOTA_CAST_ABILITY_2_ES_ROLL = 574,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CAST_ABILITY_2_ES_ROLL_END", Value=575)]
      ACT_DOTA_CAST_ABILITY_2_ES_ROLL_END = 575,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_NIAN_PIN_START", Value=576)]
      ACT_DOTA_NIAN_PIN_START = 576,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_NIAN_PIN_LOOP", Value=577)]
      ACT_DOTA_NIAN_PIN_LOOP = 577,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_NIAN_PIN_END", Value=578)]
      ACT_DOTA_NIAN_PIN_END = 578,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_LEAP_STUN", Value=579)]
      ACT_DOTA_LEAP_STUN = 579,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_LEAP_SWIPE", Value=580)]
      ACT_DOTA_LEAP_SWIPE = 580,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_NIAN_INTRO_LEAP", Value=581)]
      ACT_DOTA_NIAN_INTRO_LEAP = 581,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_AREA_DENY", Value=582)]
      ACT_DOTA_AREA_DENY = 582,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_NIAN_PIN_TO_STUN", Value=583)]
      ACT_DOTA_NIAN_PIN_TO_STUN = 583,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RAZE_1", Value=584)]
      ACT_DOTA_RAZE_1 = 584,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RAZE_2", Value=585)]
      ACT_DOTA_RAZE_2 = 585,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_RAZE_3", Value=586)]
      ACT_DOTA_RAZE_3 = 586,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_UNDYING_DECAY", Value=587)]
      ACT_DOTA_UNDYING_DECAY = 587,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_UNDYING_SOUL_RIP", Value=588)]
      ACT_DOTA_UNDYING_SOUL_RIP = 588,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_UNDYING_TOMBSTONE", Value=589)]
      ACT_DOTA_UNDYING_TOMBSTONE = 589,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_WHIRLING_AXES_RANGED", Value=590)]
      ACT_DOTA_WHIRLING_AXES_RANGED = 590,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_SHALLOW_GRAVE", Value=591)]
      ACT_DOTA_SHALLOW_GRAVE = 591,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_COLD_FEET", Value=592)]
      ACT_DOTA_COLD_FEET = 592,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ICE_VORTEX", Value=593)]
      ACT_DOTA_ICE_VORTEX = 593,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_CHILLING_TOUCH", Value=594)]
      ACT_DOTA_CHILLING_TOUCH = 594,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ENFEEBLE", Value=595)]
      ACT_DOTA_ENFEEBLE = 595,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_FATAL_BONDS", Value=596)]
      ACT_DOTA_FATAL_BONDS = 596,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_MIDNIGHT_PULSE", Value=597)]
      ACT_DOTA_MIDNIGHT_PULSE = 597,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_ANCESTRAL_SPIRIT", Value=598)]
      ACT_DOTA_ANCESTRAL_SPIRIT = 598,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_THUNDER_STRIKE", Value=599)]
      ACT_DOTA_THUNDER_STRIKE = 599,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_KINETIC_FIELD", Value=600)]
      ACT_DOTA_KINETIC_FIELD = 600,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACT_DOTA_STATIC_STORM", Value=601)]
      ACT_DOTA_STATIC_STORM = 601
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EDemoCommands")]
    public enum EDemoCommands
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_Error", Value=-1)]
      DEM_Error = -1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_Stop", Value=0)]
      DEM_Stop = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_FileHeader", Value=1)]
      DEM_FileHeader = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_FileInfo", Value=2)]
      DEM_FileInfo = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_SyncTick", Value=3)]
      DEM_SyncTick = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_SendTables", Value=4)]
      DEM_SendTables = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_ClassInfo", Value=5)]
      DEM_ClassInfo = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_StringTables", Value=6)]
      DEM_StringTables = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_Packet", Value=7)]
      DEM_Packet = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_SignonPacket", Value=8)]
      DEM_SignonPacket = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_ConsoleCmd", Value=9)]
      DEM_ConsoleCmd = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_CustomData", Value=10)]
      DEM_CustomData = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_CustomDataCallbacks", Value=11)]
      DEM_CustomDataCallbacks = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_UserCmd", Value=12)]
      DEM_UserCmd = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_FullPacket", Value=13)]
      DEM_FullPacket = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_SaveGame", Value=14)]
      DEM_SaveGame = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_Max", Value=15)]
      DEM_Max = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEM_IsCompressed", Value=112)]
      DEM_IsCompressed = 112
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EDOTAChatWheelMessage")]
    public enum EDOTAChatWheelMessage
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Ok", Value=0)]
      k_EDOTA_CW_Ok = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Care", Value=1)]
      k_EDOTA_CW_Care = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_GetBack", Value=2)]
      k_EDOTA_CW_GetBack = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_NeedWards", Value=3)]
      k_EDOTA_CW_NeedWards = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Stun", Value=4)]
      k_EDOTA_CW_Stun = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Help", Value=5)]
      k_EDOTA_CW_Help = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Push", Value=6)]
      k_EDOTA_CW_Push = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_GoodJob", Value=7)]
      k_EDOTA_CW_GoodJob = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Missing", Value=8)]
      k_EDOTA_CW_Missing = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Missing_Top", Value=9)]
      k_EDOTA_CW_Missing_Top = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Missing_Mid", Value=10)]
      k_EDOTA_CW_Missing_Mid = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Missing_Bottom", Value=11)]
      k_EDOTA_CW_Missing_Bottom = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Go", Value=12)]
      k_EDOTA_CW_Go = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Initiate", Value=13)]
      k_EDOTA_CW_Initiate = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Follow", Value=14)]
      k_EDOTA_CW_Follow = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Group_Up", Value=15)]
      k_EDOTA_CW_Group_Up = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Spread_Out", Value=16)]
      k_EDOTA_CW_Spread_Out = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Split_Farm", Value=17)]
      k_EDOTA_CW_Split_Farm = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Attack", Value=18)]
      k_EDOTA_CW_Attack = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_BRB", Value=19)]
      k_EDOTA_CW_BRB = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Dive", Value=20)]
      k_EDOTA_CW_Dive = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_OMW", Value=21)]
      k_EDOTA_CW_OMW = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Get_Ready", Value=22)]
      k_EDOTA_CW_Get_Ready = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Bait", Value=23)]
      k_EDOTA_CW_Bait = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Heal", Value=24)]
      k_EDOTA_CW_Heal = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Mana", Value=25)]
      k_EDOTA_CW_Mana = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_OOM", Value=26)]
      k_EDOTA_CW_OOM = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Skill_Cooldown", Value=27)]
      k_EDOTA_CW_Skill_Cooldown = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Ulti_Ready", Value=28)]
      k_EDOTA_CW_Ulti_Ready = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Enemy_Returned", Value=29)]
      k_EDOTA_CW_Enemy_Returned = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_All_Missing", Value=30)]
      k_EDOTA_CW_All_Missing = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Enemy_Incoming", Value=31)]
      k_EDOTA_CW_Enemy_Incoming = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Invis_Enemy", Value=32)]
      k_EDOTA_CW_Invis_Enemy = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Enemy_Had_Rune", Value=33)]
      k_EDOTA_CW_Enemy_Had_Rune = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Split_Push", Value=34)]
      k_EDOTA_CW_Split_Push = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Coming_To_Gank", Value=35)]
      k_EDOTA_CW_Coming_To_Gank = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Request_Gank", Value=36)]
      k_EDOTA_CW_Request_Gank = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Fight_Under_Tower", Value=37)]
      k_EDOTA_CW_Fight_Under_Tower = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Deny_Tower", Value=38)]
      k_EDOTA_CW_Deny_Tower = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Buy_Courier", Value=39)]
      k_EDOTA_CW_Buy_Courier = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Upgrade_Courier", Value=40)]
      k_EDOTA_CW_Upgrade_Courier = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Need_Detection", Value=41)]
      k_EDOTA_CW_Need_Detection = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_They_Have_Detection", Value=42)]
      k_EDOTA_CW_They_Have_Detection = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Buy_TP", Value=43)]
      k_EDOTA_CW_Buy_TP = 43,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Reuse_Courier", Value=44)]
      k_EDOTA_CW_Reuse_Courier = 44,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Deward", Value=45)]
      k_EDOTA_CW_Deward = 45,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Building_Mek", Value=46)]
      k_EDOTA_CW_Building_Mek = 46,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Building_Pipe", Value=47)]
      k_EDOTA_CW_Building_Pipe = 47,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Stack_And_Pull", Value=48)]
      k_EDOTA_CW_Stack_And_Pull = 48,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Pull", Value=49)]
      k_EDOTA_CW_Pull = 49,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Pulling", Value=50)]
      k_EDOTA_CW_Pulling = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Stack", Value=51)]
      k_EDOTA_CW_Stack = 51,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Jungling", Value=52)]
      k_EDOTA_CW_Jungling = 52,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Roshan", Value=53)]
      k_EDOTA_CW_Roshan = 53,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Affirmative", Value=54)]
      k_EDOTA_CW_Affirmative = 54,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Wait", Value=55)]
      k_EDOTA_CW_Wait = 55,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Pause", Value=56)]
      k_EDOTA_CW_Pause = 56,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Current_Time", Value=57)]
      k_EDOTA_CW_Current_Time = 57,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Check_Runes", Value=58)]
      k_EDOTA_CW_Check_Runes = 58,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Smoke_Gank", Value=59)]
      k_EDOTA_CW_Smoke_Gank = 59,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_GLHF", Value=60)]
      k_EDOTA_CW_GLHF = 60,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Nice", Value=61)]
      k_EDOTA_CW_Nice = 61,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Thanks", Value=62)]
      k_EDOTA_CW_Thanks = 62,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Sorry", Value=63)]
      k_EDOTA_CW_Sorry = 63,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_No_Give_Up", Value=64)]
      k_EDOTA_CW_No_Give_Up = 64,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Just_Happened", Value=65)]
      k_EDOTA_CW_Just_Happened = 65,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Game_Is_Hard", Value=66)]
      k_EDOTA_CW_Game_Is_Hard = 66,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_New_Meta", Value=67)]
      k_EDOTA_CW_New_Meta = 67,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_My_Bad", Value=68)]
      k_EDOTA_CW_My_Bad = 68,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Regret", Value=69)]
      k_EDOTA_CW_Regret = 69,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Relax", Value=70)]
      k_EDOTA_CW_Relax = 70,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_MissingHero", Value=71)]
      k_EDOTA_CW_MissingHero = 71,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_ReturnedHero", Value=72)]
      k_EDOTA_CW_ReturnedHero = 72
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EDOTAStatPopupTypes")]
    public enum EDOTAStatPopupTypes
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_SPT_Textline", Value=0)]
      k_EDOTA_SPT_Textline = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_SPT_Basic", Value=1)]
      k_EDOTA_SPT_Basic = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_SPT_Poll", Value=2)]
      k_EDOTA_SPT_Poll = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_MODIFIER_ENTRY_TYPE")]
    public enum DOTA_MODIFIER_ENTRY_TYPE
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_MODIFIER_ENTRY_TYPE_ACTIVE", Value=1)]
      DOTA_MODIFIER_ENTRY_TYPE_ACTIVE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_MODIFIER_ENTRY_TYPE_REMOVED", Value=2)]
      DOTA_MODIFIER_ENTRY_TYPE_REMOVED = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EDotaUserMessages")]
    public enum EDotaUserMessages
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_AddUnitToSelection", Value=64)]
      DOTA_UM_AddUnitToSelection = 64,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_AIDebugLine", Value=65)]
      DOTA_UM_AIDebugLine = 65,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ChatEvent", Value=66)]
      DOTA_UM_ChatEvent = 66,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_CombatHeroPositions", Value=67)]
      DOTA_UM_CombatHeroPositions = 67,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_CombatLogData", Value=68)]
      DOTA_UM_CombatLogData = 68,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_CombatLogShowDeath", Value=70)]
      DOTA_UM_CombatLogShowDeath = 70,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_CreateLinearProjectile", Value=71)]
      DOTA_UM_CreateLinearProjectile = 71,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_DestroyLinearProjectile", Value=72)]
      DOTA_UM_DestroyLinearProjectile = 72,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_DodgeTrackingProjectiles", Value=73)]
      DOTA_UM_DodgeTrackingProjectiles = 73,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_GlobalLightColor", Value=74)]
      DOTA_UM_GlobalLightColor = 74,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_GlobalLightDirection", Value=75)]
      DOTA_UM_GlobalLightDirection = 75,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_InvalidCommand", Value=76)]
      DOTA_UM_InvalidCommand = 76,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_LocationPing", Value=77)]
      DOTA_UM_LocationPing = 77,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_MapLine", Value=78)]
      DOTA_UM_MapLine = 78,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_MiniKillCamInfo", Value=79)]
      DOTA_UM_MiniKillCamInfo = 79,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_MinimapDebugPoint", Value=80)]
      DOTA_UM_MinimapDebugPoint = 80,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_MinimapEvent", Value=81)]
      DOTA_UM_MinimapEvent = 81,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_NevermoreRequiem", Value=82)]
      DOTA_UM_NevermoreRequiem = 82,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_OverheadEvent", Value=83)]
      DOTA_UM_OverheadEvent = 83,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_SetNextAutobuyItem", Value=84)]
      DOTA_UM_SetNextAutobuyItem = 84,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_SharedCooldown", Value=85)]
      DOTA_UM_SharedCooldown = 85,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_SpectatorPlayerClick", Value=86)]
      DOTA_UM_SpectatorPlayerClick = 86,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_TutorialTipInfo", Value=87)]
      DOTA_UM_TutorialTipInfo = 87,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_UnitEvent", Value=88)]
      DOTA_UM_UnitEvent = 88,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ParticleManager", Value=89)]
      DOTA_UM_ParticleManager = 89,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_BotChat", Value=90)]
      DOTA_UM_BotChat = 90,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_HudError", Value=91)]
      DOTA_UM_HudError = 91,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ItemPurchased", Value=92)]
      DOTA_UM_ItemPurchased = 92,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_Ping", Value=93)]
      DOTA_UM_Ping = 93,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ItemFound", Value=94)]
      DOTA_UM_ItemFound = 94,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_CharacterSpeakConcept", Value=95)]
      DOTA_UM_CharacterSpeakConcept = 95,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_SwapVerify", Value=96)]
      DOTA_UM_SwapVerify = 96,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_WorldLine", Value=97)]
      DOTA_UM_WorldLine = 97,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_TournamentDrop", Value=98)]
      DOTA_UM_TournamentDrop = 98,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ItemAlert", Value=99)]
      DOTA_UM_ItemAlert = 99,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_HalloweenDrops", Value=100)]
      DOTA_UM_HalloweenDrops = 100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ChatWheel", Value=101)]
      DOTA_UM_ChatWheel = 101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ReceivedXmasGift", Value=102)]
      DOTA_UM_ReceivedXmasGift = 102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_UpdateSharedContent", Value=103)]
      DOTA_UM_UpdateSharedContent = 103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_TutorialRequestExp", Value=104)]
      DOTA_UM_TutorialRequestExp = 104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_TutorialPingMinimap", Value=105)]
      DOTA_UM_TutorialPingMinimap = 105,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_GamerulesStateChanged", Value=106)]
      DOTA_UM_GamerulesStateChanged = 106,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ShowSurvey", Value=107)]
      DOTA_UM_ShowSurvey = 107,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_TutorialFade", Value=108)]
      DOTA_UM_TutorialFade = 108,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_AddQuestLogEntry", Value=109)]
      DOTA_UM_AddQuestLogEntry = 109,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_SendStatPopup", Value=110)]
      DOTA_UM_SendStatPopup = 110,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_TutorialFinish", Value=111)]
      DOTA_UM_TutorialFinish = 111,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_SendRoshanPopup", Value=112)]
      DOTA_UM_SendRoshanPopup = 112,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_SendGenericToolTip", Value=113)]
      DOTA_UM_SendGenericToolTip = 113,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_SendFinalGold", Value=114)]
      DOTA_UM_SendFinalGold = 114,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_CustomMsg", Value=115)]
      DOTA_UM_CustomMsg = 115,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_CoachHUDPing", Value=116)]
      DOTA_UM_CoachHUDPing = 116,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ClientLoadGridNav", Value=117)]
      DOTA_UM_ClientLoadGridNav = 117,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_AbilityPing", Value=118)]
      DOTA_UM_AbilityPing = 118,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_ShowGenericPopup", Value=119)]
      DOTA_UM_ShowGenericPopup = 119,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_VoteStart", Value=120)]
      DOTA_UM_VoteStart = 120,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_VoteUpdate", Value=121)]
      DOTA_UM_VoteUpdate = 121,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_VoteEnd", Value=122)]
      DOTA_UM_VoteEnd = 122,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_BoosterState", Value=123)]
      DOTA_UM_BoosterState = 123,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_WillPurchaseAlert", Value=124)]
      DOTA_UM_WillPurchaseAlert = 124,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_TutorialMinimapPosition", Value=125)]
      DOTA_UM_TutorialMinimapPosition = 125,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_PlayerMMR", Value=126)]
      DOTA_UM_PlayerMMR = 126,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_AbilitySteal", Value=127)]
      DOTA_UM_AbilitySteal = 127,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UM_CourierKilledAlert", Value=128)]
      DOTA_UM_CourierKilledAlert = 128
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_CHAT_MESSAGE")]
    public enum DOTA_CHAT_MESSAGE
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_INVALID", Value=-1)]
      CHAT_MESSAGE_INVALID = -1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_HERO_KILL", Value=0)]
      CHAT_MESSAGE_HERO_KILL = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_HERO_DENY", Value=1)]
      CHAT_MESSAGE_HERO_DENY = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_BARRACKS_KILL", Value=2)]
      CHAT_MESSAGE_BARRACKS_KILL = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_TOWER_KILL", Value=3)]
      CHAT_MESSAGE_TOWER_KILL = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_TOWER_DENY", Value=4)]
      CHAT_MESSAGE_TOWER_DENY = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_FIRSTBLOOD", Value=5)]
      CHAT_MESSAGE_FIRSTBLOOD = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_STREAK_KILL", Value=6)]
      CHAT_MESSAGE_STREAK_KILL = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_BUYBACK", Value=7)]
      CHAT_MESSAGE_BUYBACK = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_AEGIS", Value=8)]
      CHAT_MESSAGE_AEGIS = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_ROSHAN_KILL", Value=9)]
      CHAT_MESSAGE_ROSHAN_KILL = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_COURIER_LOST", Value=10)]
      CHAT_MESSAGE_COURIER_LOST = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_COURIER_RESPAWNED", Value=11)]
      CHAT_MESSAGE_COURIER_RESPAWNED = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_GLYPH_USED", Value=12)]
      CHAT_MESSAGE_GLYPH_USED = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_ITEM_PURCHASE", Value=13)]
      CHAT_MESSAGE_ITEM_PURCHASE = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_CONNECT", Value=14)]
      CHAT_MESSAGE_CONNECT = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_DISCONNECT", Value=15)]
      CHAT_MESSAGE_DISCONNECT = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_DISCONNECT_WAIT_FOR_RECONNECT", Value=16)]
      CHAT_MESSAGE_DISCONNECT_WAIT_FOR_RECONNECT = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_DISCONNECT_TIME_REMAINING", Value=17)]
      CHAT_MESSAGE_DISCONNECT_TIME_REMAINING = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_DISCONNECT_TIME_REMAINING_PLURAL", Value=18)]
      CHAT_MESSAGE_DISCONNECT_TIME_REMAINING_PLURAL = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_RECONNECT", Value=19)]
      CHAT_MESSAGE_RECONNECT = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_PLAYER_LEFT", Value=20)]
      CHAT_MESSAGE_PLAYER_LEFT = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_SAFE_TO_LEAVE", Value=21)]
      CHAT_MESSAGE_SAFE_TO_LEAVE = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_RUNE_PICKUP", Value=22)]
      CHAT_MESSAGE_RUNE_PICKUP = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_RUNE_BOTTLE", Value=23)]
      CHAT_MESSAGE_RUNE_BOTTLE = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_INTHEBAG", Value=24)]
      CHAT_MESSAGE_INTHEBAG = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_SECRETSHOP", Value=25)]
      CHAT_MESSAGE_SECRETSHOP = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_ITEM_AUTOPURCHASED", Value=26)]
      CHAT_MESSAGE_ITEM_AUTOPURCHASED = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_ITEMS_COMBINED", Value=27)]
      CHAT_MESSAGE_ITEMS_COMBINED = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_SUPER_CREEPS", Value=28)]
      CHAT_MESSAGE_SUPER_CREEPS = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_CANT_USE_ACTION_ITEM", Value=29)]
      CHAT_MESSAGE_CANT_USE_ACTION_ITEM = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_CHARGES_EXHAUSTED", Value=30)]
      CHAT_MESSAGE_CHARGES_EXHAUSTED = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_CANTPAUSE", Value=31)]
      CHAT_MESSAGE_CANTPAUSE = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_NOPAUSESLEFT", Value=32)]
      CHAT_MESSAGE_NOPAUSESLEFT = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_CANTPAUSEYET", Value=33)]
      CHAT_MESSAGE_CANTPAUSEYET = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_PAUSED", Value=34)]
      CHAT_MESSAGE_PAUSED = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_UNPAUSE_COUNTDOWN", Value=35)]
      CHAT_MESSAGE_UNPAUSE_COUNTDOWN = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_UNPAUSED", Value=36)]
      CHAT_MESSAGE_UNPAUSED = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_AUTO_UNPAUSED", Value=37)]
      CHAT_MESSAGE_AUTO_UNPAUSED = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_YOUPAUSED", Value=38)]
      CHAT_MESSAGE_YOUPAUSED = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_CANTUNPAUSETEAM", Value=39)]
      CHAT_MESSAGE_CANTUNPAUSETEAM = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_VOICE_TEXT_BANNED", Value=41)]
      CHAT_MESSAGE_VOICE_TEXT_BANNED = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_SPECTATORS_WATCHING_THIS_GAME", Value=42)]
      CHAT_MESSAGE_SPECTATORS_WATCHING_THIS_GAME = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_REPORT_REMINDER", Value=43)]
      CHAT_MESSAGE_REPORT_REMINDER = 43,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_ECON_ITEM", Value=44)]
      CHAT_MESSAGE_ECON_ITEM = 44,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_TAUNT", Value=45)]
      CHAT_MESSAGE_TAUNT = 45,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_RANDOM", Value=46)]
      CHAT_MESSAGE_RANDOM = 46,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_RD_TURN", Value=47)]
      CHAT_MESSAGE_RD_TURN = 47,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_DROP_RATE_BONUS", Value=49)]
      CHAT_MESSAGE_DROP_RATE_BONUS = 49,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_NO_BATTLE_POINTS", Value=50)]
      CHAT_MESSAGE_NO_BATTLE_POINTS = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_DENIED_AEGIS", Value=51)]
      CHAT_MESSAGE_DENIED_AEGIS = 51,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_INFORMATIONAL", Value=52)]
      CHAT_MESSAGE_INFORMATIONAL = 52,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_AEGIS_STOLEN", Value=53)]
      CHAT_MESSAGE_AEGIS_STOLEN = 53,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_ROSHAN_CANDY", Value=54)]
      CHAT_MESSAGE_ROSHAN_CANDY = 54,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_ITEM_GIFTED", Value=55)]
      CHAT_MESSAGE_ITEM_GIFTED = 55,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_HERO_KILL_WITH_GREEVIL", Value=56)]
      CHAT_MESSAGE_HERO_KILL_WITH_GREEVIL = 56,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_HOLDOUT_TOWER_DESTROYED", Value=57)]
      CHAT_MESSAGE_HOLDOUT_TOWER_DESTROYED = 57,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_HOLDOUT_WALL_DESTROYED", Value=58)]
      CHAT_MESSAGE_HOLDOUT_WALL_DESTROYED = 58,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_HOLDOUT_WALL_FINISHED", Value=59)]
      CHAT_MESSAGE_HOLDOUT_WALL_FINISHED = 59,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_PLAYER_LEFT_LIMITED_HERO", Value=62)]
      CHAT_MESSAGE_PLAYER_LEFT_LIMITED_HERO = 62,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_ABANDON_LIMITED_HERO_EXPLANATION", Value=63)]
      CHAT_MESSAGE_ABANDON_LIMITED_HERO_EXPLANATION = 63,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_DISCONNECT_LIMITED_HERO", Value=64)]
      CHAT_MESSAGE_DISCONNECT_LIMITED_HERO = 64,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_LOW_PRIORITY_COMPLETED_EXPLANATION", Value=65)]
      CHAT_MESSAGE_LOW_PRIORITY_COMPLETED_EXPLANATION = 65,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_RECRUITMENT_DROP_RATE_BONUS", Value=66)]
      CHAT_MESSAGE_RECRUITMENT_DROP_RATE_BONUS = 66,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_FROSTIVUS_SHINING_BOOSTER_ACTIVE", Value=67)]
      CHAT_MESSAGE_FROSTIVUS_SHINING_BOOSTER_ACTIVE = 67,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_PLAYER_LEFT_AFK", Value=73)]
      CHAT_MESSAGE_PLAYER_LEFT_AFK = 73,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_PLAYER_LEFT_DISCONNECTED_TOO_LONG", Value=74)]
      CHAT_MESSAGE_PLAYER_LEFT_DISCONNECTED_TOO_LONG = 74,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_PLAYER_ABANDONED", Value=75)]
      CHAT_MESSAGE_PLAYER_ABANDONED = 75,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_PLAYER_ABANDONED_AFK", Value=76)]
      CHAT_MESSAGE_PLAYER_ABANDONED_AFK = 76,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_PLAYER_ABANDONED_DISCONNECTED_TOO_LONG", Value=77)]
      CHAT_MESSAGE_PLAYER_ABANDONED_DISCONNECTED_TOO_LONG = 77,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_WILL_NOT_BE_SCORED", Value=78)]
      CHAT_MESSAGE_WILL_NOT_BE_SCORED = 78,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_WILL_NOT_BE_SCORED_RANKED", Value=79)]
      CHAT_MESSAGE_WILL_NOT_BE_SCORED_RANKED = 79,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_WILL_NOT_BE_SCORED_NETWORK", Value=80)]
      CHAT_MESSAGE_WILL_NOT_BE_SCORED_NETWORK = 80,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_WILL_NOT_BE_SCORED_NETWORK_RANKED", Value=81)]
      CHAT_MESSAGE_WILL_NOT_BE_SCORED_NETWORK_RANKED = 81,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_CAN_QUIT_WITHOUT_ABANDON", Value=82)]
      CHAT_MESSAGE_CAN_QUIT_WITHOUT_ABANDON = 82,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_RANKED_GAME_STILL_SCORED_LEAVERS_GET_LOSS", Value=83)]
      CHAT_MESSAGE_RANKED_GAME_STILL_SCORED_LEAVERS_GET_LOSS = 83,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_ABANDON_RANKED_BEFORE_FIRST_BLOOD_PARTY", Value=84)]
      CHAT_MESSAGE_ABANDON_RANKED_BEFORE_FIRST_BLOOD_PARTY = 84,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_MESSAGE_COMPENDIUM_LEVEL", Value=85)]
      CHAT_MESSAGE_COMPENDIUM_LEVEL = 85
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_NO_BATTLE_POINTS_REASONS")]
    public enum DOTA_NO_BATTLE_POINTS_REASONS
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NO_BATTLE_POINTS_WRONG_LOBBY_TYPE", Value=1)]
      NO_BATTLE_POINTS_WRONG_LOBBY_TYPE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NO_BATTLE_POINTS_PRACTICE_BOTS", Value=2)]
      NO_BATTLE_POINTS_PRACTICE_BOTS = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NO_BATTLE_POINTS_CHEATS_ENABLED", Value=3)]
      NO_BATTLE_POINTS_CHEATS_ENABLED = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NO_BATTLE_POINTS_LOW_PRIORITY", Value=4)]
      NO_BATTLE_POINTS_LOW_PRIORITY = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_CHAT_INFORMATIONAL")]
    public enum DOTA_CHAT_INFORMATIONAL
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INFO_COOP_BATTLE_POINTS_RULES", Value=1)]
      INFO_COOP_BATTLE_POINTS_RULES = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INFO_FROSTIVUS_ABANDON_REMINDER", Value=2)]
      INFO_FROSTIVUS_ABANDON_REMINDER = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INFO_RANKED_REMINDER", Value=3)]
      INFO_RANKED_REMINDER = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INFO_COOP_LOW_PRIORITY_PASSIVE_REMINDER", Value=4)]
      INFO_COOP_LOW_PRIORITY_PASSIVE_REMINDER = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_ABILITY_PING_TYPE")]
    public enum DOTA_ABILITY_PING_TYPE
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ABILITY_PING_READY", Value=1)]
      ABILITY_PING_READY = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ABILITY_PING_MANA", Value=2)]
      ABILITY_PING_MANA = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ABILITY_PING_COOLDOWN", Value=3)]
      ABILITY_PING_COOLDOWN = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_COMBATLOG_TYPES")]
    public enum DOTA_COMBATLOG_TYPES
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_COMBATLOG_DAMAGE", Value=0)]
      DOTA_COMBATLOG_DAMAGE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_COMBATLOG_HEAL", Value=1)]
      DOTA_COMBATLOG_HEAL = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_COMBATLOG_MODIFIER_ADD", Value=2)]
      DOTA_COMBATLOG_MODIFIER_ADD = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_COMBATLOG_MODIFIER_REMOVE", Value=3)]
      DOTA_COMBATLOG_MODIFIER_REMOVE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_COMBATLOG_DEATH", Value=4)]
      DOTA_COMBATLOG_DEATH = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_COMBATLOG_ABILITY", Value=5)]
      DOTA_COMBATLOG_ABILITY = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_COMBATLOG_ITEM", Value=6)]
      DOTA_COMBATLOG_ITEM = 6
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EDotaEntityMessages")]
    public enum EDotaEntityMessages
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_SPEECH", Value=0)]
      DOTA_UNIT_SPEECH = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_SPEECH_MUTE", Value=1)]
      DOTA_UNIT_SPEECH_MUTE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ADD_GESTURE", Value=2)]
      DOTA_UNIT_ADD_GESTURE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_REMOVE_GESTURE", Value=3)]
      DOTA_UNIT_REMOVE_GESTURE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_REMOVE_ALL_GESTURES", Value=4)]
      DOTA_UNIT_REMOVE_ALL_GESTURES = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_FADE_GESTURE", Value=6)]
      DOTA_UNIT_FADE_GESTURE = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_SPEECH_CLIENTSIDE_RULES", Value=7)]
      DOTA_UNIT_SPEECH_CLIENTSIDE_RULES = 7
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_PARTICLE_MESSAGE")]
    public enum DOTA_PARTICLE_MESSAGE
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_CREATE", Value=0)]
      DOTA_PARTICLE_MANAGER_EVENT_CREATE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_UPDATE", Value=1)]
      DOTA_PARTICLE_MANAGER_EVENT_UPDATE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_FORWARD", Value=2)]
      DOTA_PARTICLE_MANAGER_EVENT_UPDATE_FORWARD = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_ORIENTATION", Value=3)]
      DOTA_PARTICLE_MANAGER_EVENT_UPDATE_ORIENTATION = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_FALLBACK", Value=4)]
      DOTA_PARTICLE_MANAGER_EVENT_UPDATE_FALLBACK = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_ENT", Value=5)]
      DOTA_PARTICLE_MANAGER_EVENT_UPDATE_ENT = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_OFFSET", Value=6)]
      DOTA_PARTICLE_MANAGER_EVENT_UPDATE_OFFSET = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_DESTROY", Value=7)]
      DOTA_PARTICLE_MANAGER_EVENT_DESTROY = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_DESTROY_INVOLVING", Value=8)]
      DOTA_PARTICLE_MANAGER_EVENT_DESTROY_INVOLVING = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_RELEASE", Value=9)]
      DOTA_PARTICLE_MANAGER_EVENT_RELEASE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_LATENCY", Value=10)]
      DOTA_PARTICLE_MANAGER_EVENT_LATENCY = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_SHOULD_DRAW", Value=11)]
      DOTA_PARTICLE_MANAGER_EVENT_SHOULD_DRAW = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_PARTICLE_MANAGER_EVENT_FROZEN", Value=12)]
      DOTA_PARTICLE_MANAGER_EVENT_FROZEN = 12
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_OVERHEAD_ALERT")]
    public enum DOTA_OVERHEAD_ALERT
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_GOLD", Value=0)]
      OVERHEAD_ALERT_GOLD = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_DENY", Value=1)]
      OVERHEAD_ALERT_DENY = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_CRITICAL", Value=2)]
      OVERHEAD_ALERT_CRITICAL = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_XP", Value=3)]
      OVERHEAD_ALERT_XP = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_BONUS_SPELL_DAMAGE", Value=4)]
      OVERHEAD_ALERT_BONUS_SPELL_DAMAGE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_MISS", Value=5)]
      OVERHEAD_ALERT_MISS = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_DAMAGE", Value=6)]
      OVERHEAD_ALERT_DAMAGE = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_EVADE", Value=7)]
      OVERHEAD_ALERT_EVADE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_BLOCK", Value=8)]
      OVERHEAD_ALERT_BLOCK = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_BONUS_POISON_DAMAGE", Value=9)]
      OVERHEAD_ALERT_BONUS_POISON_DAMAGE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_HEAL", Value=10)]
      OVERHEAD_ALERT_HEAL = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_MANA_ADD", Value=11)]
      OVERHEAD_ALERT_MANA_ADD = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_MANA_LOSS", Value=12)]
      OVERHEAD_ALERT_MANA_LOSS = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_LAST_HIT_EARLY", Value=13)]
      OVERHEAD_ALERT_LAST_HIT_EARLY = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_LAST_HIT_CLOSE", Value=14)]
      OVERHEAD_ALERT_LAST_HIT_CLOSE = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERHEAD_ALERT_LAST_HIT_MISS", Value=15)]
      OVERHEAD_ALERT_LAST_HIT_MISS = 15
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"NET_Messages")]
    public enum NET_Messages
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"net_NOP", Value=0)]
      net_NOP = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"net_Disconnect", Value=1)]
      net_Disconnect = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"net_File", Value=2)]
      net_File = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"net_SplitScreenUser", Value=3)]
      net_SplitScreenUser = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"net_Tick", Value=4)]
      net_Tick = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"net_StringCmd", Value=5)]
      net_StringCmd = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"net_SetConVar", Value=6)]
      net_SetConVar = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"net_SignonState", Value=7)]
      net_SignonState = 7
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"CLC_Messages")]
    public enum CLC_Messages
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_ClientInfo", Value=8)]
      clc_ClientInfo = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_Move", Value=9)]
      clc_Move = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_VoiceData", Value=10)]
      clc_VoiceData = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_BaselineAck", Value=11)]
      clc_BaselineAck = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_ListenEvents", Value=12)]
      clc_ListenEvents = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_RespondCvarValue", Value=13)]
      clc_RespondCvarValue = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_FileCRCCheck", Value=14)]
      clc_FileCRCCheck = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_LoadingProgress", Value=15)]
      clc_LoadingProgress = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_SplitPlayerConnect", Value=16)]
      clc_SplitPlayerConnect = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"clc_ClientMessage", Value=17)]
      clc_ClientMessage = 17
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"VoiceDataFormat_t")]
    public enum VoiceDataFormat_t
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"VOICEDATA_FORMAT_STEAM", Value=0)]
      VOICEDATA_FORMAT_STEAM = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"VOICEDATA_FORMAT_ENGINE", Value=1)]
      VOICEDATA_FORMAT_ENGINE = 1
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"SVC_Messages")]
    public enum SVC_Messages
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_ServerInfo", Value=8)]
      svc_ServerInfo = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_SendTable", Value=9)]
      svc_SendTable = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_ClassInfo", Value=10)]
      svc_ClassInfo = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_SetPause", Value=11)]
      svc_SetPause = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_CreateStringTable", Value=12)]
      svc_CreateStringTable = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_UpdateStringTable", Value=13)]
      svc_UpdateStringTable = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_VoiceInit", Value=14)]
      svc_VoiceInit = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_VoiceData", Value=15)]
      svc_VoiceData = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_Print", Value=16)]
      svc_Print = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_Sounds", Value=17)]
      svc_Sounds = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_SetView", Value=18)]
      svc_SetView = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_FixAngle", Value=19)]
      svc_FixAngle = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_CrosshairAngle", Value=20)]
      svc_CrosshairAngle = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_BSPDecal", Value=21)]
      svc_BSPDecal = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_SplitScreen", Value=22)]
      svc_SplitScreen = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_UserMessage", Value=23)]
      svc_UserMessage = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_EntityMessage", Value=24)]
      svc_EntityMessage = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_GameEvent", Value=25)]
      svc_GameEvent = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_PacketEntities", Value=26)]
      svc_PacketEntities = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_TempEntities", Value=27)]
      svc_TempEntities = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_Prefetch", Value=28)]
      svc_Prefetch = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_Menu", Value=29)]
      svc_Menu = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_GameEventList", Value=30)]
      svc_GameEventList = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_GetCvarValue", Value=31)]
      svc_GetCvarValue = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_PacketReliable", Value=32)]
      svc_PacketReliable = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"svc_FullFrameSplit", Value=33)]
      svc_FullFrameSplit = 33
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ESplitScreenMessageType")]
    public enum ESplitScreenMessageType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MSG_SPLITSCREEN_ADDUSER", Value=0)]
      MSG_SPLITSCREEN_ADDUSER = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MSG_SPLITSCREEN_REMOVEUSER", Value=1)]
      MSG_SPLITSCREEN_REMOVEUSER = 1
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ENetworkDisconnectionReason")]
    public enum ENetworkDisconnectionReason
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_INVALID", Value=0)]
      NETWORK_DISCONNECT_INVALID = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SHUTDOWN", Value=1)]
      NETWORK_DISCONNECT_SHUTDOWN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DISCONNECT_BY_USER", Value=2)]
      NETWORK_DISCONNECT_DISCONNECT_BY_USER = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DISCONNECT_BY_SERVER", Value=3)]
      NETWORK_DISCONNECT_DISCONNECT_BY_SERVER = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_LOST", Value=4)]
      NETWORK_DISCONNECT_LOST = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_OVERFLOW", Value=5)]
      NETWORK_DISCONNECT_OVERFLOW = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_BANNED", Value=6)]
      NETWORK_DISCONNECT_STEAM_BANNED = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_INUSE", Value=7)]
      NETWORK_DISCONNECT_STEAM_INUSE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_TICKET", Value=8)]
      NETWORK_DISCONNECT_STEAM_TICKET = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_LOGON", Value=9)]
      NETWORK_DISCONNECT_STEAM_LOGON = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_AUTHCANCELLED", Value=10)]
      NETWORK_DISCONNECT_STEAM_AUTHCANCELLED = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_AUTHALREADYUSED", Value=11)]
      NETWORK_DISCONNECT_STEAM_AUTHALREADYUSED = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_AUTHINVALID", Value=12)]
      NETWORK_DISCONNECT_STEAM_AUTHINVALID = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_VACBANSTATE", Value=13)]
      NETWORK_DISCONNECT_STEAM_VACBANSTATE = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_LOGGED_IN_ELSEWHERE", Value=14)]
      NETWORK_DISCONNECT_STEAM_LOGGED_IN_ELSEWHERE = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_VAC_CHECK_TIMEDOUT", Value=15)]
      NETWORK_DISCONNECT_STEAM_VAC_CHECK_TIMEDOUT = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_DROPPED", Value=16)]
      NETWORK_DISCONNECT_STEAM_DROPPED = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STEAM_OWNERSHIP", Value=17)]
      NETWORK_DISCONNECT_STEAM_OWNERSHIP = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SERVERINFO_OVERFLOW", Value=18)]
      NETWORK_DISCONNECT_SERVERINFO_OVERFLOW = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_TICKMSG_OVERFLOW", Value=19)]
      NETWORK_DISCONNECT_TICKMSG_OVERFLOW = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_STRINGTABLEMSG_OVERFLOW", Value=20)]
      NETWORK_DISCONNECT_STRINGTABLEMSG_OVERFLOW = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DELTAENTMSG_OVERFLOW", Value=21)]
      NETWORK_DISCONNECT_DELTAENTMSG_OVERFLOW = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_TEMPENTMSG_OVERFLOW", Value=22)]
      NETWORK_DISCONNECT_TEMPENTMSG_OVERFLOW = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SOUNDSMSG_OVERFLOW", Value=23)]
      NETWORK_DISCONNECT_SOUNDSMSG_OVERFLOW = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SNAPSHOTOVERFLOW", Value=24)]
      NETWORK_DISCONNECT_SNAPSHOTOVERFLOW = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_SNAPSHOTERROR", Value=25)]
      NETWORK_DISCONNECT_SNAPSHOTERROR = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_RELIABLEOVERFLOW", Value=26)]
      NETWORK_DISCONNECT_RELIABLEOVERFLOW = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_BADDELTATICK", Value=27)]
      NETWORK_DISCONNECT_BADDELTATICK = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_NOMORESPLITS", Value=28)]
      NETWORK_DISCONNECT_NOMORESPLITS = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_TIMEDOUT", Value=29)]
      NETWORK_DISCONNECT_TIMEDOUT = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DISCONNECTED", Value=30)]
      NETWORK_DISCONNECT_DISCONNECTED = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_LEAVINGSPLIT", Value=31)]
      NETWORK_DISCONNECT_LEAVINGSPLIT = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_DIFFERENTCLASSTABLES", Value=32)]
      NETWORK_DISCONNECT_DIFFERENTCLASSTABLES = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_BADRELAYPASSWORD", Value=33)]
      NETWORK_DISCONNECT_BADRELAYPASSWORD = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_BADSPECTATORPASSWORD", Value=34)]
      NETWORK_DISCONNECT_BADSPECTATORPASSWORD = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_HLTVRESTRICTED", Value=35)]
      NETWORK_DISCONNECT_HLTVRESTRICTED = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_NOSPECTATORS", Value=36)]
      NETWORK_DISCONNECT_NOSPECTATORS = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_HLTVUNAVAILABLE", Value=37)]
      NETWORK_DISCONNECT_HLTVUNAVAILABLE = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_HLTVSTOP", Value=38)]
      NETWORK_DISCONNECT_HLTVSTOP = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_KICKED", Value=39)]
      NETWORK_DISCONNECT_KICKED = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_BANADDED", Value=40)]
      NETWORK_DISCONNECT_BANADDED = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_KICKBANADDED", Value=41)]
      NETWORK_DISCONNECT_KICKBANADDED = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_HLTVDIRECT", Value=42)]
      NETWORK_DISCONNECT_HLTVDIRECT = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_PURESERVER_CLIENTEXTRA", Value=43)]
      NETWORK_DISCONNECT_PURESERVER_CLIENTEXTRA = 43,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_PURESERVER_MISMATCH", Value=44)]
      NETWORK_DISCONNECT_PURESERVER_MISMATCH = 44,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_USERCMD", Value=45)]
      NETWORK_DISCONNECT_USERCMD = 45,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NETWORK_DISCONNECT_REJECTED_BY_GAME", Value=46)]
      NETWORK_DISCONNECT_REJECTED_BY_GAME = 46
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"SIGNONSTATE")]
    public enum SIGNONSTATE
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNONSTATE_NONE", Value=0)]
      SIGNONSTATE_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNONSTATE_CHALLENGE", Value=1)]
      SIGNONSTATE_CHALLENGE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNONSTATE_CONNECTED", Value=2)]
      SIGNONSTATE_CONNECTED = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNONSTATE_NEW", Value=3)]
      SIGNONSTATE_NEW = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNONSTATE_PRESPAWN", Value=4)]
      SIGNONSTATE_PRESPAWN = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNONSTATE_SPAWN", Value=5)]
      SIGNONSTATE_SPAWN = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNONSTATE_FULL", Value=6)]
      SIGNONSTATE_FULL = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNONSTATE_CHANGELEVEL", Value=7)]
      SIGNONSTATE_CHANGELEVEL = 7
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EBaseUserMessages")]
    public enum EBaseUserMessages
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_AchievementEvent", Value=1)]
      UM_AchievementEvent = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_CloseCaption", Value=2)]
      UM_CloseCaption = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_CloseCaptionDirect", Value=3)]
      UM_CloseCaptionDirect = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_CurrentTimescale", Value=4)]
      UM_CurrentTimescale = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_DesiredTimescale", Value=5)]
      UM_DesiredTimescale = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_Fade", Value=6)]
      UM_Fade = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_GameTitle", Value=7)]
      UM_GameTitle = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_Geiger", Value=8)]
      UM_Geiger = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_HintText", Value=9)]
      UM_HintText = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_HudMsg", Value=10)]
      UM_HudMsg = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_HudText", Value=11)]
      UM_HudText = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_KeyHintText", Value=12)]
      UM_KeyHintText = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_MessageText", Value=13)]
      UM_MessageText = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_RequestState", Value=14)]
      UM_RequestState = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_ResetHUD", Value=15)]
      UM_ResetHUD = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_Rumble", Value=16)]
      UM_Rumble = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_SayText", Value=17)]
      UM_SayText = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_SayText2", Value=18)]
      UM_SayText2 = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_SayTextChannel", Value=19)]
      UM_SayTextChannel = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_Shake", Value=20)]
      UM_Shake = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_ShakeDir", Value=21)]
      UM_ShakeDir = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_StatsCrawlMsg", Value=22)]
      UM_StatsCrawlMsg = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_StatsSkipState", Value=23)]
      UM_StatsSkipState = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_TextMsg", Value=24)]
      UM_TextMsg = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_Tilt", Value=25)]
      UM_Tilt = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_Train", Value=26)]
      UM_Train = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_VGUIMenu", Value=27)]
      UM_VGUIMenu = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_VoiceMask", Value=28)]
      UM_VoiceMask = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_VoiceSubtitle", Value=29)]
      UM_VoiceSubtitle = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_SendAudio", Value=30)]
      UM_SendAudio = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_CameraTransition", Value=31)]
      UM_CameraTransition = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UM_MAX_BASE", Value=63)]
      UM_MAX_BASE = 63
    }
  
}