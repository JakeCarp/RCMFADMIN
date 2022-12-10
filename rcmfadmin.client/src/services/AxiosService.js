import Axios from "axios";
import { baseURL } from "../env";
export const mySQL = Axios.create({
  baseURL,
  timeout: 8000,
});
