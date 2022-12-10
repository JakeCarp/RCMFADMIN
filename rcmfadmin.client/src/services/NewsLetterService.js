import { AppState } from "../AppState.js";
import { Newsletter } from "../models/Newsletter.js";
import { mySQL } from "./AxiosService.js";

class NewsLetterService {
  async getNewsletterSubscribers() {
    const res = await mySQL.get("newsLetter");
    AppState.newsletterSubscribers = res.data.map((n) => new Newsletter(n));
  }

  async createSubscriber(subscriberData) {
    const res = await mySQL.post("newsletter", subscriberData);
    let newSubscriber = new Newsletter(res.data);
    AppState.newsletterSubscribers.push(newSubscriber);
  }
}
export const newsLetterService = new  NewsLetterService();
