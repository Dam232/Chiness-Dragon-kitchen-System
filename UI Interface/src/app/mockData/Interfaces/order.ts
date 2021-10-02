export class OrderDataInf {
  OrdeRreference ?: string = '';
    OrderType ?: string= '';
    OrderDate ?: string= '';
    Status ?: string= '';
    Menu?: Array<{
      desription: string;
      Qty: number;
     }>;
}