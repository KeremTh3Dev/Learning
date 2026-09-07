using System;

namespace Learning.Homeworks
{
    public class PacketValidator
    {
        public const int MaxPacketSize = 1024;
        public const byte MinSecurityLevel = 5;

        public bool IsValidPacket(int packetSize, bool isEncrypted, bool isBlacklisted, byte securityLevel)
        {
            return packetSize <= MaxPacketSize && isEncrypted && !isBlacklisted && securityLevel >= MinSecurityLevel;
        }
        public byte GenerateChecksum(int portNumber, int payloadSize)
        {
            return (byte) ((portNumber * 3) + payloadSize);
        }
    }
}
