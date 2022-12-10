import { AppState } from "../AppState.js";
import { Sponsor } from "../models/Sponsor.js";
import { mySQL } from "./AxiosService.js";

class SponsorsService {
  async getSponsors() {
    const res = await mySQL.get("sponsors");
    console.log(res.data);
    AppState.sponsors = res.data.map((s) => new Sponsor(s));
  }
  async getSponsorById(sponsorId) {
    const res = await mySQL.get(`sponsors/${sponsorId}`);
    AppState.activeSponsor = new Sponsor(res.data);
  }

  async createSponsor(sponsorData) {
    const res = await mySQL.post("sponsors", sponsorData);
    let newSponsor = new Sponsor(res.data);
    AppState.sponsors.push(newSponsor);
  }

  async deleteSponsor(sponsorId) {
    await mySQL.delete(`sponsors/${sponsorId}`);
    AppState.sponsors.filter((x) => x.id != sponsorId);
  }

  async editSponsor(sponsorData) {
    const res = await mySQL.put(`sponsors`, sponsorData);
    let updatedSponsor = new Sponsor(res.data);
    let index = AppState.sponsors.findIndex((s) => {
      s.id == sponsorData.id;
    });
    AppState.sponsors.splice(index, 1);
    AppState.sponsors.push(updatedSponsor);
  }
}
export const sponsorsService = new SponsorsService();
