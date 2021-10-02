import { KeyValue } from "./responseData/KeyValue";


export class ResponseBean {
    constructor(
        public responseCode: string,
        public responseMsg: string,
        public messageType: string,
        public message: string,
        public content: KeyValue[]
    ) {}
}
