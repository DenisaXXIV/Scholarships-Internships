import { Pin } from "./pin.model";

export interface Note {
  id: string;
  title: string;
  description: string;
  deadLine: Date;
  isUrgent: boolean;
  pin: Pin;
  background: string;
}
