namespace Lab19
{
    /// <summary>
    /// Models a Television object
    /// </summary>
    public class Television
    {
        private ushort _channel;
        private byte _volume;
        private const ushort _MIN_CHANNEL = 2;
        private const ushort _MAX_CHANNEL = 50;

        private const byte MIN_VOLUME = 0;
        private const byte MAX_VOLUME = 30;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Television()
        {
            _channel = _MIN_CHANNEL;
            _volume = 5;
        }

        /// <summary>
        /// Television's channel
        /// </summary>
        public ushort Channel
        {
            set
            {
                if (value >= _MIN_CHANNEL && value <= _MAX_CHANNEL)
                {
                    _channel = value;
                }
            }

            get { return _channel; }
        }

        /// <summary>
        ///  increment the volume to be no greater then the max volume
        /// </summary>
        public void VolumeUp()
        {
            if (_volume < MAX_VOLUME)
            {
                _volume++;
            }
        }

        /// <summary>
        ///  decrement the volume to be no greater then the min volume
        /// </summary>
        public void VolumeDown()
        {
            if (_volume > MIN_VOLUME)
            {
                _volume--;
            }
        }

        /// <summary>
        /// Sets the channel if valid
        /// </summary>
        /// <param name="channel"> the channel to set the TV to</param>
        public void SetChannel(ushort channel)
        {
            if (channel >= _MIN_CHANNEL && channel <= _MAX_CHANNEL)
            {
                _channel = channel;
            }
        }

        /// <summary>
        /// Increments the Television's channel, or if the Television is currently equal to MAX_CHANNEL,
        /// will set the Television's channel to the MIN_CHANNEL
        /// </summary>
        public void ChannelUp()
        {
            if (_channel == _MAX_CHANNEL)
            {
                _channel = _MIN_CHANNEL;
            }
            else
            {
                _channel++;
            }
        }
        /// <summary>
        /// Decrements the Television's channel, or if the Television is currently equal to MIN_CHANNEL,
        /// will set the Television's channel to the MAX_CHANNEL
        /// </summary>
        public void ChannelDown()
        {
            if (_channel == _MIN_CHANNEL)
            {
                _channel = _MAX_CHANNEL;
            }
            else
            {
                _channel--;
            }
        }

        /// <summary>
        /// Creates a string representation of the Television & volume
        /// </summary>
        /// <returns>The string representation of the Television</returns>
        override public string ToString()
        {
            //could also use the public get property Channel

            return $"TV-> current channel: {_channel} current volume: {_volume}";
        }
    }
}
