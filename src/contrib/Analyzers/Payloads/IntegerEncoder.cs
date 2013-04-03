/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Lucene.Net.Index;
using Lucene.Net.Util;

namespace Lucene.Net.Analysis.Payloads
{
    /// <summary>
    /// Encode a character array Integer as a {@link org.apache.lucene.index.Payload}.
    /// </summary>
    /// <seealso cref="PayloadHelper.EncodeInt(int, byte[], int)"/>
    public class IntegerEncoder : AbstractEncoder, PayloadEncoder
    {
        public override Payload Encode(char[] buffer, int offset, int length)
        {
            Payload result = new Payload();
            int payload = ArrayUtil.ParseInt(buffer, offset, length);//TODO: improve this so that we don't have to new Strings
            byte[] bytes = PayloadHelper.EncodeInt(payload);
            result.SetData(bytes);
            return result;
        }
    }
}
