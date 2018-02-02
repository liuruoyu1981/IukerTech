/***********************************************************************************************
Author：
CreateDate: 1/1/2018 4:58:17 PM
Email: 
***********************************************************************************************/


/*
Protobuf协议序列化器实现
*/

using System.IO;
using Iuker.Common.Serialize;
using ProtoBuf.Meta;

namespace IukerTech_ThreeKingdoms
{
public class IukerTech_ThreeKingdoms_ProtobufSerializer_Proxy : ISerializer
{
        private readonly TypeModel mTypeModel;

        public IukerTech_ThreeKingdoms_ProtobufSerializer_Proxy()
        {
            mTypeModel = new IukerTech_ThreeKingdoms_ProtobufSerializer();
        }

        public byte[] Serialize(object value)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                mTypeModel.Serialize(ms, value);
                ms.Position = 0;
                int length = (int)ms.Length;
                var buffer = new byte[length];
                ms.Read(buffer, 0, length);
                return buffer;
            }
        }

        public T DeSerialize<T>(byte[] messageBytes) where T : class, new()
        {
            using (MemoryStream ms = new MemoryStream(messageBytes))
            {
                var message = mTypeModel.Deserialize(ms, null, typeof(T)) as T;
                return message;
            }
        }
        }
        }
